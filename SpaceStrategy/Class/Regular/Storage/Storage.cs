using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Storage : Building
    {
        public Storage
            (
            double maxResoursesOccupyingSpace, double curResoursesOccupyingSpace, List<ResourseBunch> resourseBunches,                                          // IResourseHolder                                                                                                   // House constructor
            string name, Type buildingType, int occupyingSpace, int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units,                       // Building
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            )
            : base(
                  name, buildingType, occupyingSpace, maxUnitsOccupyingSpace, curUnitsOccupyingSpace, units,        // Building
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.MaxResoursesOccupyingSpace = maxResoursesOccupyingSpace;
            this.CurResoursesOccupyingSpace = curResoursesOccupyingSpace;
            this.ResourseBunches = resourseBunches;
        }

        public ResourseBunch FindByResourseId(int id)
        {
            return ResourseBunches.Find(r => r.Resourse.Id == id);
        }
    }
}
