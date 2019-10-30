using SpaceStrategy.Class.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular.Implementation
{
    class ColonyHolder : IColonyHolder
    {
        public ColonyHolder
            (
            string name, int maxColoniesOccupyingSpace, int curColoniesOccupyingSpace, List<Colony> colonies
            )
        {
            this.Name = name;
            this.MaxColoniesOccupyingSpace = maxColoniesOccupyingSpace;
            this.CurColoniesOccupyingSpace = curColoniesOccupyingSpace;
            this.Colonies = colonies;
        }

        public string Name { get; }

        public int MaxColoniesOccupyingSpace { get; }

        public int CurColoniesOccupyingSpace { get; private set; }

        public List<Colony> Colonies { get; }















        private void AddSingle(Colony t)
        {
            CurColoniesOccupyingSpace += t.CurBuildingsOccupyingSpace;
            Colonies.Add(t);
        }

        private void RemoveSingle(Colony t)
        {
            Colonies.Remove(t);
            CurColoniesOccupyingSpace -= t.CurBuildingsOccupyingSpace;
        }

        private bool IsEnoughSpace(Colony t)
        {
            return CurColoniesOccupyingSpace + t.CurBuildingsOccupyingSpace <= MaxColoniesOccupyingSpace;
        }

        private bool IsEnoughSpace(List<Colony> ts)
        {
            int sum = 0;

            ts.ForEach(t => sum += t.CurBuildingsOccupyingSpace);

            return CurColoniesOccupyingSpace + sum <= MaxColoniesOccupyingSpace;
        }

        private bool Contains(Colony t)
        {
            return Colonies.Contains(t);
        }

        private bool Contains(List<Colony> ts)
        {
            bool contains = true;

            ts.ForEach(t => contains = contains && Colonies.Contains(t));

            return contains;
        }















        public bool Add(Colony t)
        {
            if(IsEnoughSpace(t))
            {
                AddSingle(t);

                return true;
            }

            return false;
        }

        public bool Add(List<Colony> ts)
        {
            if(IsEnoughSpace(ts))
            {
                ts.ForEach(t => AddSingle(t));

                return true;
            }

            return false;
        }

        public bool Move(Colony t, IGeneralHolder<Colony> generalHolder)
        {
            if(Contains(t) &&
                generalHolder.Add(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Move(List<Colony> ts, IGeneralHolder<Colony> generalHolder)
        {
            if(Contains(ts) &&
                generalHolder.Add(ts))
            {
                Remove(ts);

                return true;
            }

            return false;
        }

        public bool Remove(Colony t)
        {
            if(Contains(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Remove(List<Colony> ts)
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
