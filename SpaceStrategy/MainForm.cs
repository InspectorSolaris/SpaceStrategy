using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Abstract;
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
        private GameState GameState { get; }

        public MainForm()
        {
            GameState = GameState.GenerateNew(21, 10);

            InitializeComponent();
            InitializeGame();

            MainGameLoop.RunWorkerAsync();
        }

        private void InitializeGame()
        {
            SetStaticDataSources();
            SetDynamicDataSources();
        }

        private void SetStaticDataSources()
        {
            Planets.DataSource              = GameState.Planets;
            ChoosenPlanet.DataSource        = GameState.Planets;
            AddChoosenColony.DataSource     = GameState.ColonyTypes;
            AddChoosenStarShip.DataSource   = GameState.StarShipTypes;
            AddChoosenBuilding.DataSource   = GameState.BuildingTypes;
            AddChoosenUnit.DataSource       = GameState.UnitTypes;
        }

        private void SetDynamicDataSourcesNull()
        {
            Colonies.DataSource = null;
            PlanetResourses.DataSource = null;
            Buildings.DataSource = null;
            StarShips.DataSource = null;
            ColonyResourses.DataSource = null;
            ChoosenBuilding.DataSource = null;
            ChoosenUnit.DataSource = null;
            Units.DataSource = null;
            StarShipColonies.DataSource = null;
            StarShipUnits.DataSource = null;
            StarShipColonyResourses.DataSource = null;
        }

        private void SetDynamicDataSources()
        {
            if(Planets.SelectedIndex != -1)
            {
                Planet p = GameState.Planets[Planets.SelectedIndex];

                Colonies.DataSource         = p.Colonies;
                PlanetResourses.DataSource  = p.ResourseBunches;
            }
            else
            {
                Colonies.DataSource         = null;
                PlanetResourses.DataSource  = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1)
            {
                Colony c = GameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex];

                Buildings.DataSource = c.Buildings;
                StarShips.DataSource = c.StarShips;
                ColonyResourses.DataSource = c.ResourseBunches;
                ChoosenBuilding.DataSource = c.Buildings;
            }
            else
            {
                Buildings.DataSource = null;
                StarShips.DataSource = null;
                ColonyResourses.DataSource = null;
                ChoosenBuilding.DataSource = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                Buildings.SelectedIndex != -1)
            {
                Building b = GameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].Buildings[Buildings.SelectedIndex];

                Units.DataSource = b.Units;
                ChoosenUnit.DataSource = b.Units;
            }
            else
            {
                Units.DataSource = null;
                ChoosenUnit.DataSource = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                StarShips.SelectedIndex != -1)
            {
                StarShip ss = GameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].StarShips[StarShips.SelectedIndex];

                StarShipColonies.DataSource = ss.Colonies;
                StarShipUnits.DataSource    = ss.Units;
            }
            else
            {
                StarShipColonies.DataSource = null;
                StarShipUnits.DataSource    = null;
            }

            if(Planets.SelectedIndex != -1 &&
                Colonies.SelectedIndex != -1 &&
                StarShips.SelectedIndex != -1 &&
                StarShipColonies.SelectedIndex != -1)
            {
                Colony c = GameState.Planets[Planets.SelectedIndex].Colonies[Colonies.SelectedIndex].StarShips[StarShips.SelectedIndex].Colonies[StarShipColonies.SelectedIndex];

                StarShipColonyResourses.DataSource = c.ResourseHolder.ResourseBunches;
            }
            else
            {
                StarShipColonyResourses.DataSource = null;
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

        private void MainGameLoop_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                GameState.GameTick();
            }
        }

        private void AddBuildingToPlanetColony_Click(object sender, EventArgs e)
        {
            GameState.OnAddBuildingToPlanetColony(Planets.SelectedIndex, Colonies.SelectedIndex, AddChoosenBuilding.SelectedIndex);
        }

        private void AddUnitToColonyBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnAddUnitToPlanetColony(Planets.SelectedIndex, Colonies.SelectedIndex, Buildings.SelectedIndex, AddChoosenUnit.SelectedIndex);
        }

        private void Buildings_DoubleClick(object sender, EventArgs e)
        {
            GameState.OnBuildingsDoubleClick(Planets.SelectedIndex, Colonies.SelectedIndex, Buildings.SelectedIndex);
        }

        private void BuildBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnBuildBuildingClick(Planets.SelectedIndex, Colonies.SelectedIndex, ChoosenBuilding.SelectedIndex);
        }

        private void DestroyBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnDestroyBuildingClick(Planets.SelectedIndex, Colonies.SelectedIndex, ChoosenBuilding.SelectedIndex);
        }

        private void BuildUnit_Click(object sender, EventArgs e)
        {
            GameState.OnBuildUnitClick(Planets.SelectedIndex, Colonies.SelectedIndex, Buildings.SelectedIndex, ChoosenUnit.SelectedIndex);
        }

        private void DestroyUnit_Click(object sender, EventArgs e)
        {
            GameState.OnDestroyUnitClick(Planets.SelectedIndex, Colonies.SelectedIndex, Buildings.SelectedIndex, ChoosenUnit.SelectedIndex);
        }
    }
}
