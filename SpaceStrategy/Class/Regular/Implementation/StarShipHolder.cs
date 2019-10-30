using SpaceStrategy.Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular.Implementation
{
    class StarShipHolder : IStarShipHolder
    {
        public StarShipHolder
            (
            string name, int maxStarShipsOccupyingSpace, int curStarShipsOccupyingSpace, List<StarShip> starShips
            )
        {
            this.Name = name;
            this.MaxStarShipsOccupyingSpace = maxStarShipsOccupyingSpace;
            this.CurStarShipsOccupyingSpace = curStarShipsOccupyingSpace;
            this.StarShips = starShips;
        }

        public string Name { get; }

        public int MaxStarShipsOccupyingSpace { get; }

        public int CurStarShipsOccupyingSpace { get; private set; }

        public List<StarShip> StarShips { get; }















        private void AddSingle(StarShip t)
        {
            CurStarShipsOccupyingSpace += 1;
            StarShips.Add(t);
        }

        private void RemoveSingle(StarShip t)
        {
            StarShips.Remove(t);
            CurStarShipsOccupyingSpace -= 1;
        }

        private bool IsEnoughSpace(StarShip t)
        {
            return CurStarShipsOccupyingSpace + 1 <= MaxStarShipsOccupyingSpace;
        }

        private bool IsEnoughSpace(List<StarShip> ts)
        {
            int sum = 0;

            ts.ForEach(t => sum += 1);

            return CurStarShipsOccupyingSpace + sum <= MaxStarShipsOccupyingSpace;
        }

        private bool Contains(StarShip t)
        {
            return StarShips.Contains(t);
        }

        private bool Contains(List<StarShip> ts)
        {
            bool contains = true;

            ts.ForEach(t => contains = contains && StarShips.Contains(t));

            return contains;
        }















        public bool Add(StarShip t)
        {
            if(IsEnoughSpace(t))
            {
                AddSingle(t);

                return true;
            }

            return false;
        }

        public bool Add(List<StarShip> ts)
        {
            if(IsEnoughSpace(ts))
            {
                ts.ForEach(t => AddSingle(t));

                return true;
            }

            return false;
        }

        public bool Move(StarShip t, IGeneralHolder<StarShip> generalHolder)
        {
            if(Contains(t) &&
                generalHolder.Add(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Move(List<StarShip> ts, IGeneralHolder<StarShip> generalHolder)
        {
            if(Contains(ts) &&
                generalHolder.Add(ts))
            {
                Remove(ts);

                return true;
            }

            return false;
        }

        public bool Remove(StarShip t)
        {
            if(Contains(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Remove(List<StarShip> ts)
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
