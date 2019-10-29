using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStrategy
{
    public partial class MainForm : Form
    {
        private GameState gameState { get; set; } = GameState.GenerateNew(21, 10);

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            SetStaticDataSources();
            SetDynamicDataSources();
        }

        private void SetStaticDataSources()
        {
            Planets.DataSource = gameState.Planets;
        }

        private void SetDynamicDataSources()
        {
            if(Planets.SelectedIndex != -1)
            {
                Colonies.DataSource         = gameState.Planets[Planets.SelectedIndex].Colonies;
                PlanetResourses.DataSource  = gameState.Planets[Planets.SelectedIndex].ResourseBunches;
            }
            else
            {
                Colonies.DataSource         = null;
                PlanetResourses.DataSource  = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1)
            {
                Buildings.DataSource = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings;
                StarShips.DataSource = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].StarShips;

                ChoosenBuilding.DataSource = Buildings.DataSource;
            }
            else
            {
                Buildings.DataSource = null;
                StarShips.DataSource = null;

                ChoosenBuilding.DataSource = Buildings.DataSource;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                Buildings.SelectedIndex != -1)
            {
                Units.DataSource = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings[Buildings.SelectedIndex].Units;
            }
            else
            {
                Units.DataSource = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                Buildings.SelectedIndex != -1 &&
                Units.SelectedIndex != -1)
            {
                UnitState.DataSource = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings[Buildings.SelectedIndex].Units[Units.SelectedIndex];
            }
            else
            {
                UnitState.DataSource = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                Buildings.SelectedIndex != -1 &&
                gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings[Buildings.SelectedIndex].BuildingType == Class.Abstract.Building.Type.Storage)
            {
                BuildingResourses.DataSource = ((Storage)gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings[Buildings.SelectedIndex]).ResourseBunches;
            }
            else
            {
                BuildingResourses.DataSource = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                StarShips.SelectedIndex != -1)
            {
                StarShipColonies.DataSource = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].StarShips[StarShips.SelectedIndex].Colonies;
                StarShipUnits.DataSource    = gameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].StarShips[StarShips.SelectedIndex].Units;
            }
            else
            {
                StarShipColonies.DataSource = null;
                StarShipUnits.DataSource    = null;
            }
        }

        private void Planets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDynamicDataSources();
        }

        private void Colonies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDynamicDataSources();
        }

        private void Buildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDynamicDataSources();
        }

        private void Units_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDynamicDataSources();
        }

        private void StarShips_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDynamicDataSources();
        }

        private void StarShipColonies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StarShipUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddChoosenColony_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddChoosenStarShip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddChoosenBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddChoosenUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChoosenPlanet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChoosenBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
