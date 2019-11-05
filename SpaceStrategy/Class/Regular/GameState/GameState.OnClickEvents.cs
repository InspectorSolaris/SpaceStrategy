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
        public void OnBuildingsDoubleClick(Building b)
        {
            if(b != null && b.BuildingType != Building.Type.House)
            {
                ResourseBuilding rb = (ResourseBuilding)b;

                rb.ChangeIsWorkingState();
            }
        }

        public void OnBuildBuildingClick(Building b, Colony c)
        {
            if(b != null && c != null && c.Buildings.Contains(b))
            {
                b.Build(c.ResourseHolder);
            }
        }

        public void OnDestroyBuildingClick(Building b)
        {
            if(b != null)
            {
                b.Destory();
            }
        }

        public void OnBuildUnitClick(Unit u, Building b, Colony c)
        {
            if(u != null && b != null && c != null &&
                c.Buildings.Contains(b) && b.Units.Contains(u))
            {
                u.Build(c.ResourseHolder);
            }
        }

        public void OnDestroyUnitClick(Unit u)
        {
            if(u != null)
            {
                u.Destory();
            }
        }

        public void OnAddBuildingToPlanetColony(Colony c, BuildingType bt)
        {
            if(c == null || bt == null)
            {
                return;
            }

            switch(bt.Type)
            {
                case Building.Type.House:
                    HouseType ht = (HouseType)bt;

                    c.Add(
                        House.Create(ht, c.Buildings.Sum(x => x.BuildingType == Building.Type.House ? 1 : 0))
                        );

                    break;
                case Building.Type.Mine:
                    MineType mt = (MineType)bt;

                    c.Add(
                        Mine.Create(mt, c.Buildings.Sum(x => x.BuildingType == Building.Type.Mine ? 1 : 0))
                        );

                    break;
                case Building.Type.Factory:
                    FactoryType ft = (FactoryType)bt;

                    c.Add(
                        Factory.Create(ft, c.Buildings.Sum(x => x.BuildingType == Building.Type.Factory ? 1 : 0))
                        );

                    break;
            }

        }

        public void OnAddUnitToPlanetColony(Building b, UnitType ut)
        {
            if(b == null || ut == null)
            {
                return;
            }

            b.Add(
                Unit.Create(ut, b.Units.Count)
                );
        }
    }
}
