using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Planet : IColonyHolder
    {
        private ColonyHolder ColonyHolder { get; }

        public int MaxColoniesOccupyingSpace
        {
            get
            {
                return ColonyHolder.MaxColoniesOccupyingSpace;
            }
        }

        public int CurColoniesOccupyingSpace
        {
            get
            {
                return ColonyHolder.CurColoniesOccupyingSpace;
            }
        }

        public List<Colony> Colonies
        {
            get
            {
                return ColonyHolder.Colonies;
            }
        }

        public bool Add(Colony t)
        {
            return ColonyHolder.Add(t);
        }

        public bool Add(List<Colony> ts)
        {
            return ColonyHolder.Add(ts);
        }

        public bool Move(Colony t, IGeneralHolder<Colony> generalHolder)
        {
            return ColonyHolder.Move(t, generalHolder);
        }

        public bool Move(List<Colony> ts, IGeneralHolder<Colony> generalHolder)
        {
            return ColonyHolder.Move(ts, generalHolder);
        }

        public bool Remove(Colony t)
        {
            return ColonyHolder.Remove(t);
        }

        public bool Remove(List<Colony> ts)
        {
            return ColonyHolder.Remove(ts);
        }
    }
}
