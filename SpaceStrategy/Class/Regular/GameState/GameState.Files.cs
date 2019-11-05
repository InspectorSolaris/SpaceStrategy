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

        private static void InitFromFile(string filePath, Action<Queue<string>> addSingleType)
        {
            List<string> str = File.ReadAllLines(filePath).OfType<string>().ToList();

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

                Queue<string> args = new Queue<string>(
                    ss.Split(DelimiterChars).OfType<string>().ToList()
                    );

                addSingleType(args);
            }
        }

        private static List<ResourseBunch> ReadNecessaryResourses(Queue<string> args)
        {
            List<ResourseBunch> necessaryResourses = new List<ResourseBunch>();

            foreach(Resourse r in Resourses)
            {
                necessaryResourses.Add(
                    new ResourseBunch(r, double.Parse(args.Dequeue()))
                    );
            }

            return necessaryResourses;
        }

        private static void AddSingleResourseType(Queue<string> args)
        {
            Resourses.Add(
                Resourse.Create(args)
                );
        }

        private static void AddSingleColonyType(Queue<string> args)
        {
            ColonyTypes.Add(
                ColonyType.Create(args, ReadNecessaryResourses(args))
                );
        }

        private static void AddSingleStarShipType(Queue<string> args)
        {
            StarShipTypes.Add(
                StarShipType.Create(args, ReadNecessaryResourses(args))
                );
        }
        private static void AddSingleBuildingType(Queue<string> args)
        {
            Building.Type type;

            switch(args.Dequeue())
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

            switch(type)
            {
                case Building.Type.House:
                    BuildingTypes.Add(
                        HouseType.Create(args, ReadNecessaryResourses(args))
                        );
                    break;
                case Building.Type.Mine:
                    BuildingTypes.Add(
                        MineType.Create(args, ReadNecessaryResourses(args))
                        );
                    break;
                case Building.Type.Factory:
                    BuildingTypes.Add(
                        FactoryType.Create(args, ReadNecessaryResourses(args))
                        );
                    break;
                default:
                    throw new Exception("Incorrect BuildingType Init");
            }
        }
        private static void AddSingleUnitType(Queue<string> args)
        {
            UnitTypes.Add(
                UnitType.Create(args, ReadNecessaryResourses(args))
                );
        }
    }
}
