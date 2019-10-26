using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class Building : IUnitHolder
    {
        public int MaxUnitsOccupyingSpace { get; }

        public int CurUnitsOccupyingSpace { get; private set; }

        public List<Unit> Units { get; }















        private void AddSingle(Unit t)
        {
            CurUnitsOccupyingSpace += 1;
            Units.Add(t);
        }

        private void RemoveSingle(Unit t)
        {
            Units.Remove(t);
            CurUnitsOccupyingSpace -= 1;
        }

        private bool IsEnoughSpace(Unit t)
        {
            return CurUnitsOccupyingSpace + 1 <= MaxUnitsOccupyingSpace;
        }

        private bool IsEnoughSpace(List<Unit> ts)
        {
            int sum = 0;

            ts.ForEach(t => sum += 1);

            return CurUnitsOccupyingSpace + sum <= MaxUnitsOccupyingSpace;
        }

        private bool Contains(Unit t)
        {
            return Units.Contains(t);
        }

        private bool Contains(List<Unit> ts)
        {
            bool contains = true;

            ts.ForEach(t => contains = contains && Units.Contains(t));

            return contains;
        }















        public bool Add(Unit t)
        {
            if(IsEnoughSpace(t))
            {
                AddSingle(t);

                return true;
            }

            return false;
        }

        public bool Add(List<Unit> ts)
        {
            if(IsEnoughSpace(ts))
            {
                ts.ForEach(t => AddSingle(t));

                return true;
            }

            return false;
        }

        public bool Move(Unit t, IGeneralHolder<Unit> generalHolder)
        {
            if(Contains(t) &&
                generalHolder.Add(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Move(List<Unit> ts, IGeneralHolder<Unit> generalHolder)
        {
            if(Contains(ts) &&
                generalHolder.Add(ts))
            {
                Remove(ts);

                return true;
            }

            return false;
        }

        public bool Remove(Unit t)
        {
            if(Contains(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Remove(List<Unit> ts)
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
