using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Abstract;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular
{
    partial class GameState
    {
        public void OnBuildingsDoubleClick(int planetInd, int colonyInd, int buildingInd)
        {
            Building b = Planets[planetInd].Colonies[colonyInd].Buildings[buildingInd];

            if(b.BuildingType != Building.Type.House)
            {
                ResourseBuilding rb = (ResourseBuilding)b;

                rb.ChangeIsWorkingState();
            }
        }

        public void OnAddBuildingToPlanetColony(int planetInd, int colonyInd, int buildingChoosenInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingChoosenInd == -1)
            {
                return;
            }

            BuildingType bt = BuildingTypes[buildingChoosenInd];
            Colony c = Planets[planetInd].Colonies[colonyInd];

            switch(bt.Type)
            {
                case Building.Type.House:
                    HouseType ht = (HouseType)bt;

                    c.Add(
                        new House(
                            ht.HealRate,
                            ht.OccupyingSpace,
                            new UnitHolder(
                                "UnitHolder",
                                ht.MaxUnitsOccupyingSpace,
                                0,
                                new List<Unit>()
                                ),
                            $"House " + c.Buildings.Sum(x => x.BuildingType == Building.Type.House ? 1 : 0).ToString("D3"),
                            Buildable.State.Destroyed,
                            ht.TimeToBuildSec,
                            ht.TimeToDestroySec,
                            ht.NecessaryResourses
                            )
                        );

                    break;
                case Building.Type.Mine:
                    MineType mt = (MineType)bt;

                    c.Add(
                        new Mine(
                            Resourses[mt.MiningResourseId],
                            mt.MineRate,
                            mt.DamageRate,
                            mt.StrengthMultipler,
                            mt.EnduranceMultipler,
                            mt.OccupyingSpace,
                            new UnitHolder(
                                "UnitHolder",
                                mt.MaxUnitsOccupyingSpace,
                                0,
                                new List<Unit>()
                                ),
                            $"Mine " + c.Buildings.Sum(x => x.BuildingType == Building.Type.Mine ? 1 : 0).ToString("D3"),
                            Buildable.State.Destroyed,
                            mt.TimeToBuildSec,
                            mt.TimeToDestroySec,
                            mt.NecessaryResourses
                            )
                        );

                    break;
                case Building.Type.Factory:
                    FactoryType ft = (FactoryType)bt;

                    c.Add(
                        new Factory(
                            Resourses[ft.RawResourseId],
                            Resourses[ft.ProductResourseId],
                            ft.FactoryRate,
                            ft.DamageRate,
                            ft.StrengthMultipler,
                            ft.EnduranceMultipler,
                            ft.OccupyingSpace,
                            new UnitHolder(
                                "UnitHolder",
                                ft.MaxUnitsOccupyingSpace,
                                0,
                                new List<Unit>()
                                ),
                            $"Factory " + c.Buildings.Sum(x => x.BuildingType == Building.Type.Factory ? 1 : 0).ToString("D3"),
                            Buildable.State.Destroyed,
                            ft.TimeToBuildSec,
                            ft.TimeToDestroySec,
                            ft.NecessaryResourses
                            )
                        );

                    break;
            }

        }

        public void OnAddUnitToPlanetColony(int planetInd, int colonyInd, int buildingInd, int unitChoosenInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingInd == -1 ||
                unitChoosenInd == -1)
            {
                return;
            }

            UnitType ut = UnitTypes[unitChoosenInd];
            Building b = Planets[planetInd].Colonies[colonyInd].Buildings[buildingInd];

            b.Add(
                new Unit(
                    ut.MaxHealth,
                    ut.Strength,
                    ut.Endurance,
                    $"Unit " + b.Units.Sum(x => 1),
                    Buildable.State.Destroyed,
                    ut.TimeToBuildSec,
                    ut.TimeToDestroySec,
                    ut.NecessaryResourses
                    )
                );
        }

        public void OnBuildBuildingClick(int planetInd, int colonyInd, int buildingInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingInd == -1)
            {
                return;
            }

            Colony c = Planets[planetInd].Colonies[colonyInd];
            Building b = c.Buildings[buildingInd];

            b.Build(c.ResourseHolder);
        }

        public void OnDestroyBuildingClick(int planetInd, int colonyInd, int buildingInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingInd == -1)
            {
                return;
            }

            Colony c = Planets[planetInd].Colonies[colonyInd];
            Building b = c.Buildings[buildingInd];

            b.Destory();
        }

        public void OnBuildUnitClick(int planetInd, int colonyInd, int buildingInd, int unitInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingInd == -1 ||
                unitInd == -1)
            {
                return;
            }

            Colony c = Planets[planetInd].Colonies[colonyInd];
            Building b = c.Buildings[buildingInd];
            Unit u = b.Units[unitInd];

            u.Build(c.ResourseHolder);
        }

        public void OnDestroyUnitClick(int planetInd, int colonyInd, int buildingInd, int unitInd)
        {
            if(planetInd == -1 ||
                colonyInd == -1 ||
                buildingInd == -1 ||
                unitInd == -1)
            {
                return;
            }

            Colony c = Planets[planetInd].Colonies[colonyInd];
            Building b = c.Buildings[buildingInd];
            Unit u = b.Units[unitInd];

            u.Destory();
        }
    }
}
