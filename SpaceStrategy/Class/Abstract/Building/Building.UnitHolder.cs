using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class Building : IUnitHolder
    {
        private UnitHolder UnitHolder { get; }

        public int MaxUnitsOccupyingSpace
        {
            get
            {
                return UnitHolder.MaxUnitsOccupyingSpace;
            }
        }

        public int CurUnitsOccupyingSpace
        {
            get
            {
                return UnitHolder.CurUnitsOccupyingSpace;
            }
        }

        public List<Unit> Units
        {
            get
            {
                return UnitHolder.Units;
            }
        }

        public bool Add(Unit t)
        {
            return UnitHolder.Add(t);
        }

        public bool Add(List<Unit> ts)
        {
            return UnitHolder.Add(ts);
        }

        public bool Move(Unit t, IGeneralHolder<Unit> generalHolder)
        {
            return UnitHolder.Move(t, generalHolder);
        }

        public bool Move(List<Unit> ts, IGeneralHolder<Unit> generalHolder)
        {
            return UnitHolder.Move(ts, generalHolder);
        }

        public bool Remove(Unit t)
        {
            return UnitHolder.Remove(t);
        }

        public bool Remove(List<Unit> ts)
        {
            return UnitHolder.Remove(ts);
        }
    }
}
