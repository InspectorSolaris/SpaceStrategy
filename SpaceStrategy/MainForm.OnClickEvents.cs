using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Abstract;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStrategy
{
    partial class MainForm
    {

        private void Buildings_DoubleClick(object sender, EventArgs e)
        {
            GameState.OnBuildingsDoubleClick((sender as ListBox).SelectedItem as Building);
        }

        private void BuildBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnBuildBuildingClick(Buildings.SelectedItem as Building, Colonies.SelectedItem as Colony);
        }

        private void DestroyBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnDestroyBuildingClick(Buildings.SelectedItem as Building);
        }

        private void BuildUnit_Click(object sender, EventArgs e)
        {
            GameState.OnBuildUnitClick(Units.SelectedItem as Unit, Buildings.SelectedItem as Building, Colonies.SelectedItem as Colony);
        }

        private void DestroyUnit_Click(object sender, EventArgs e)
        {
            GameState.OnDestroyUnitClick(Units.SelectedItem as Unit);
        }

        private void AddSelectedStarShip_Click(object sender, EventArgs e)
        {
            
        }

        private void AddSelectedColony_Click(object sender, EventArgs e)
        {
            
        }

        private void AddSelectedBuilding_Click(object sender, EventArgs e)
        {
            GameState.OnAddBuildingToPlanetColony(Colonies.SelectedItem as Colony, AddBuilding.SelectedItem as BuildingType);
        }

        private void AddSelectedUnit_Click(object sender, EventArgs e)
        {
            GameState.OnAddUnitToPlanetColony(Buildings.SelectedItem as Building, AddUnit.SelectedItem as UnitType);
        }
    }
}
