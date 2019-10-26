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
        public int MaxBuildingsOccupyingSpace { get; }

        public int CurBuildingsOccupyingSpace { get; private set; }

        public List<Building> Buildings { get; }















        private void AddSingle(Building t)
        {
            CurBuildingsOccupyingSpace += t.OccupyingSpace;
            Buildings.Add(t);
        }

        private void RemoveSingle(Building t)
        {
            Buildings.Remove(t);
            CurBuildingsOccupyingSpace -= t.OccupyingSpace;
        }

        private bool IsEnoughSpace(Building t)
        {
            return CurBuildingsOccupyingSpace + t.OccupyingSpace <= MaxBuildingsOccupyingSpace;
        }

        private bool IsEnoughSpace(List<Building> ts)
        {
            int sum = 0;

            ts.ForEach(t => sum += t.OccupyingSpace);

            return CurBuildingsOccupyingSpace + sum <= MaxBuildingsOccupyingSpace;
        }

        private bool Contains(Building t)
        {
            return Buildings.Contains(t);
        }

        private bool Contains(List<Building> ts)
        {
            bool contains = true;

            ts.ForEach(t => contains = contains && Buildings.Contains(t));

            return contains;
        }















        public bool Add(Building t)
        {
            if(IsEnoughSpace(t))
            {
                AddSingle(t);

                return true;
            }

            return false;
        }

        public bool Add(List<Building> ts)
        {
            if(IsEnoughSpace(ts))
            {
                ts.ForEach(t => AddSingle(t));

                return true;
            }

            return false;
        }

        public bool Move(Building t, IGeneralHolder<Building> generalHolder)
        {
            if(Contains(t) &&
                generalHolder.Add(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Move(List<Building> ts, IGeneralHolder<Building> generalHolder)
        {
            if(Contains(ts) &&
                generalHolder.Add(ts))
            {
                Remove(ts);

                return true;
            }

            return false;
        }

        public bool Remove(Building t)
        {
            if(Contains(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Remove(List<Building> ts)
        {
            if(Contains(ts))
            {
                ts.ForEach(t => RemoveSingle(t));

                return true;
            }

            return false;
        }
    }
}
