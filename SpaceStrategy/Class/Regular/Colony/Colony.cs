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
            string name, int maxBuildingsOccupyingSpace, int curBuildingsOccupyingSpace, List<Building> buildings
            )
        {
            this.Name = name;
            this.MaxBuildingsOccupyingSpace = maxBuildingsOccupyingSpace;
            this.CurBuildingsOccupyingSpace = curBuildingsOccupyingSpace;
            this.Buildings = buildings;
        }

        public string Name { get; }
    }
}
