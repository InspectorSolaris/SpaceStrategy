using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular
{
    partial class Colony : IStarShipHolder
    {
        private StarShipHolder StarShipHolder { get; }

        public int MaxStarShipsOccupyingSpace
        {
            get
            {
                return StarShipHolder.MaxStarShipsOccupyingSpace;
            }
        }

        public int CurStarShipsOccupyingSpace
        {
            get
            {
                return StarShipHolder.CurStarShipsOccupyingSpace;
            }
        }

        public List<StarShip> StarShips
        {
            get
            {
                return StarShipHolder.StarShips;
            }
        }

        public bool Add(StarShip t)
        {
            return StarShipHolder.Add(t);
        }

        public bool Add(List<StarShip> ts)
        {
            return StarShipHolder.Add(ts);
        }

        public bool Move(StarShip t, IGeneralHolder<StarShip> generalHolder)
        {
            return StarShipHolder.Move(t, generalHolder);
        }

        public bool Move(List<StarShip> ts, IGeneralHolder<StarShip> generalHolder)
        {
            return StarShipHolder.Move(ts, generalHolder);
        }

        public bool Remove(StarShip t)
        {
            return StarShipHolder.Remove(t);
        }

        public bool Remove(List<StarShip> ts)
        {
            return StarShipHolder.Remove(ts);
        }
    }
}
