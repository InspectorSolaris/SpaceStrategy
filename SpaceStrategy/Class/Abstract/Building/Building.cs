using System;
using System.Collections.Generic;
using System.Text;
using SpaceStrategy.Class.Regular;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class Building : Buildable
    {
        protected Building
            (
            string name, Type buildingType, int occupyingSpace,                                                                                                 // Building
            int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units,                                                                           // IUnitHolder
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            ) 
            : base(
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.Name = name;
            this.BuildingType = buildingType;
            this.OccupyingSpace = occupyingSpace;
            this.MaxUnitsOccupyingSpace = maxUnitsOccupyingSpace;
            this.CurUnitsOccupyingSpace = curUnitsOccupyingSpace;
            this.Units = units;
        }

        public enum Type
        {
            House,
            Mine,
            Factory,
            Storage
        }

        public string Name { get; }

        public Type BuildingType { get; protected set; }

        public int OccupyingSpace { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
