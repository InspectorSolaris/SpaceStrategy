using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStrategy
{
    public partial class MainForm : Form
    {
        private static double GameTickRate { get; } = 1;

        private static double UITickRate { get; } = 1;

        private static int SelectedDefault { get; } = -1;

        private GameState GameState { get; }

        public MainForm()
        {
            GameState = GameState.GenerateNew();

            InitializeComponent();
            InitializeGame();

            MainGameLoop.RunWorkerAsync();
            UIUpdater.RunWorkerAsync();
        }

        private void InitializeGame()
        {
            Planets.DataSource = GameState.Planets;

            AddStarShip.DataSource = GameState.StarShipTypes;
            AddColony.DataSource = GameState.ColonyTypes;
            AddBuilding.DataSource = GameState.BuildingTypes;
            AddUnit.DataSource = GameState.UnitTypes;
        }

        private void UpdateUIList<T>(ListBox listBox, List<T> ts, bool saveSelectedItem = true)
        {
            int selectedIndex = -1;

            if(listBox.DataSource == ts && saveSelectedItem)
            {
                selectedIndex = listBox.SelectedIndex;
            }

            listBox.DataSource = null;
            listBox.DataSource = ts;

            if(!(0 <= selectedIndex && selectedIndex < ts.Count))
            {
                selectedIndex = -1;
            }

            listBox.SelectedIndex = selectedIndex;
        }

        private void UpdateUI()
        {
            int SelectedPlanet = Planets.SelectedIndex;
            int SelectedColony = Colonies.SelectedIndex;
            int SelectedBuilding = Buildings.SelectedIndex;

            if(SelectedPlanet != SelectedDefault)
            {
                UpdateUIList(Colonies, GameState.Planets[SelectedPlanet].Colonies);
                UpdateUIList(PlanetResourses, GameState.Planets[SelectedPlanet].ResourseBunches);
            }

            if(SelectedColony != SelectedDefault)
            {
                UpdateUIList(Buildings, GameState.Planets[SelectedPlanet].Colonies[SelectedColony].Buildings);
                UpdateUIList(ColonyResourses, GameState.Planets[SelectedPlanet].Colonies[SelectedColony].ResourseBunches);
            }

            if(SelectedBuilding != SelectedDefault)
            {
                UpdateUIList(Units, GameState.Planets[SelectedPlanet].Colonies[SelectedColony].Buildings[SelectedBuilding].Units);
            }
        }

        private async void MainGameLoop_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            while(true)
            {
                stopwatch.Restart();

                GameState.GameTick();

                stopwatch.Stop();

                await Task.Delay(TimeSpan.FromSeconds(1.0 / GameTickRate) - stopwatch.Elapsed);
            }
        }

        private async void UIUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(0.125));

            while(true)
            {
                this.Invoke(new Action(
                    () => UpdateUI()
                    ));

                await Task.Delay(TimeSpan.FromSeconds(1.0 / UITickRate));
            }
        }
    }
}
