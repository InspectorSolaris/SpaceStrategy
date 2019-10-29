using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular
{
    partial class GameState
    {
        private string ResoursesSettingFilePath { get; } = "settings/resourses.s";

        private string ColonySettingFilePath { get; } = "settings/colonies.s";

        private string StarShipSettingFilePath { get; } = "settings/starships.s";

        private string BuildingSettingFilePath { get; } = "settings/buldings.s";

        private string UnitSettingFilePath { get; } = "settings/units.s";

        public static List<Resourse> Resourses { get; } = new List<Resourse>
        {
            new Resourse(1, "Watter", ""),
            new Resourse(2, "Copper", ""),
            new Resourse(3, "Silver", ""),
            new Resourse(4, "Gold", ""),
            new Resourse(5, "Platinum", "")
        };

        private void InitResourses()
        {

        }

        private void InitColonies()
        {

        }

        private void InitStarShips()
        {

        }

        private void InitBuildings()
        {

        }

        private void InitUnits()
        {

        }
    }
}
