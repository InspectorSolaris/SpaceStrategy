using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Colony : IBuildingHolder
    {
        private BuildingHolder BuildingHolder { get; }

        public int MaxBuildingsOccupyingSpace
        {
            get
            {
                return BuildingHolder.MaxBuildingsOccupyingSpace;
            }
        }

        public int CurBuildingsOccupyingSpace
        {
            get
            {
                return BuildingHolder.CurBuildingsOccupyingSpace;
            }
        }

        public List<Building> Buildings
        {
            get
            {
                return BuildingHolder.Buildings;
            }
        }

        public bool Add(Building t)
        {
            return BuildingHolder.Add(t);
        }

        public bool Add(List<Building> ts)
        {
            return BuildingHolder.Add(ts);
        }

        public bool Move(Building t, IGeneralHolder<Building> generalHolder)
        {
            return BuildingHolder.Move(t, generalHolder);
        }

        public bool Move(List<Building> ts, IGeneralHolder<Building> generalHolder)
        {
            return BuildingHolder.Move(ts, generalHolder);
        }

        public bool Remove(Building t)
        {
            return BuildingHolder.Remove(t);
        }

        public bool Remove(List<Building> ts)
        {
            return BuildingHolder.Remove(ts);
        }
    }
}
