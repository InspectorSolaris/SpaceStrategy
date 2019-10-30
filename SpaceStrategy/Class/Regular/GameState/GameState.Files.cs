using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Type.Abstract;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular
{
    partial class GameState
    {
        private static string ResourseSettingFilePath       { get; } = "settings/resourses.s";

        private static string ColonySettingFilePath         { get; } = "settings/colonies.s";

        private static string StarShipSettingFilePath       { get; } = "settings/starships.s";

        private static string BuildingSettingFilePath       { get; } = "settings/buildings.s";

        private static string UnitSettingFilePath           { get; } = "settings/units.s";

        private static char[] DelimiterChars                { get; } = { '|' };

        private static string[] CharsToRemove               { get; } = { "\t" };

        private static string[] CharsToConinue              { get; } = { "#" };

        public static List<Resourse> Resourses              { get; } = new List<Resourse>();

        public static List<ColonyType> ColonyTypes          { get; } = new List<ColonyType>();
        
        public static List<StarShipType> StarShipTypes      { get; } = new List<StarShipType>();
        
        public static List<BuildingType> BuildingTypes      { get; } = new List<BuildingType>();

        public static List<UnitType> UnitTypes              { get; } = new List<UnitType>();

        private static void InitData()
        {
            if(!Initialized)
            {
                InitFromFile(ResourseSettingFilePath, AddSingleResourseType);
                InitFromFile(ColonySettingFilePath, AddSingleColonyType);
                InitFromFile(StarShipSettingFilePath, AddSingleStarShipType);
                InitFromFile(BuildingSettingFilePath, AddSingleBuildingType);
                InitFromFile(UnitSettingFilePath, AddSingleUnitType);

                Initialized = true;
            }
        }

        private static void InitFromFile(string filePath, Action<string[]> addSingleType)
        {
            string[] str = File.ReadAllLines(filePath);

            foreach(string s in str)
            {
                bool isContinue = false;

                foreach(string ch in CharsToConinue)
                {
                    isContinue = isContinue || s.Contains(ch);
                }

                if(s.Length == 0 || isContinue)
                {
                    continue;
                }

                string ss = s;

                foreach(string ch in CharsToRemove)
                {
                    ss = ss.Replace(ch, "");
                }

                string[] args = ss.Split(DelimiterChars);
                addSingleType(args);
            }
        }

        private static void AddSingleResourseType(string[] args)
        {
            int ind = 0;
            Resourses.Add(
                new Resourse(
                    int.Parse(args[ind++]),
                    args[ind++],
                    args[ind++]
                    )
                );
        }

        private static void AddSingleColonyType(string[] args)
        {
            int ind = 0;

            List<ResourseBunch> necessaryResourses = new List<ResourseBunch>();

            foreach(Resourse r in Resourses)
            {
                necessaryResourses.Add(
                    new ResourseBunch(r, double.Parse(args[ind++]))
                    );
            }

            ColonyTypes.Add(
                new ColonyType(
                    double.Parse(args[ind++]),
                    int.Parse(args[ind++]),
                    int.Parse(args[ind++]),
                    args[ind++],
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    necessaryResourses
                    )
                );
        }

        private static void AddSingleStarShipType(string[] args)
        {
            int ind = 0;

            List<ResourseBunch> necessaryResourses = new List<ResourseBunch>();

            foreach(Resourse r in Resourses)
            {
                necessaryResourses.Add(
                    new ResourseBunch(r, double.Parse(args[ind++]))
                    );
            }

            StarShipTypes.Add(
                new StarShipType(
                    double.Parse(args[ind++]),
                    int.Parse(args[ind++]),
                    int.Parse(args[ind++]),
                    args[ind++],
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    necessaryResourses
                    )
                );
        }
        private static void AddSingleBuildingType(string[] args)
        {
            int ind = 0;

            Building.Type type;

            switch(args[ind++])
            {
                case "HOUSE":
                    type = Building.Type.House;
                    break;
                case "MINE":
                    type = Building.Type.Mine;
                    break;
                case "FACTORY":
                    type = Building.Type.Factory;
                    break;
                default:
                    throw new Exception("Incorrect BuildingType Init");
            }

            List<ResourseBunch> necessaryResourses = new List<ResourseBunch>();

            foreach(Resourse r in Resourses)
            {
                necessaryResourses.Add(
                    new ResourseBunch(r, double.Parse(args[ind++]))
                    );
            }

            switch(type)
            {
                case Building.Type.House:
                    BuildingTypes.Add(
                        new HouseType(
                            double.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            args[ind++],
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            necessaryResourses
                            )
                        );
                    break;
                case Building.Type.Mine:
                    BuildingTypes.Add(
                        new MineType(
                            int.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            args[ind++],
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            necessaryResourses
                            )
                        );
                    break;
                case Building.Type.Factory:
                    BuildingTypes.Add(
                        new FactoryType(
                            int.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            double.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            int.Parse(args[ind++]),
                            args[ind++],
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            TimeSpan.FromSeconds(double.Parse(args[ind++])),
                            necessaryResourses
                            )
                        );
                    break;
                default:
                    throw new Exception("Incorrect BuildingType Init");
            }
        }
        private static void AddSingleUnitType(string[] args)
        {
            int ind = 0;

            List<ResourseBunch> necessaryResourses = new List<ResourseBunch>();

            foreach(Resourse r in Resourses)
            {
                necessaryResourses.Add(
                    new ResourseBunch(r, double.Parse(args[ind++]))
                    );
            }

            UnitTypes.Add(
                new UnitType(
                    double.Parse(args[ind++]),
                    double.Parse(args[ind++]),
                    double.Parse(args[ind++]),
                    args[ind++],
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    TimeSpan.FromSeconds(double.Parse(args[ind++])),
                    necessaryResourses
                    )
                );
        }
    }
}
