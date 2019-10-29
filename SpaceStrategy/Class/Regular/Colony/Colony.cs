using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Colony
    {
        public Colony
            (
            string name,                                                                                // Colony
            int maxBuildingsOccupyingSpace, int curBuildingsOccupyingSpace, List<Building> buildings,   // IBuildingHolder
            int maxStarShipsOccupyingSpace, int curStarShipsOccupyingSpace, List<StarShip> starShips    // IStarShipHolder
            )
        {
            this.Name = name;
            this.MaxBuildingsOccupyingSpace = maxBuildingsOccupyingSpace;
            this.CurBuildingsOccupyingSpace = curBuildingsOccupyingSpace;
            this.Buildings = buildings;
            this.MaxStarShipsOccupyingSpace = maxStarShipsOccupyingSpace;
            this.CurStarShipsOccupyingSpace = curStarShipsOccupyingSpace;
            this.StarShips = starShips;
        }

        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }


    }
}
