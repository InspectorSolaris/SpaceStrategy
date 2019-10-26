using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Abstract
{
    abstract class ResourseBuilding : Building
    {
        protected ResourseBuilding
            (
            double damageRate, double strengthMultipler, double enduranceMultipler, Storage storage,                                                            // ResourseBuilding                                                                                                   // House constructor
            string name, Type buildingType, int occupyingSpace, int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units,                       // Building
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            )
            : base(
                  name, buildingType, occupyingSpace, maxUnitsOccupyingSpace, curUnitsOccupyingSpace, units,        // Building
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.DamageRate = damageRate;
            this.StrengthMultipler = strengthMultipler;
            this.EnduranceMultipler = enduranceMultipler;
            this.Storage = storage;
        }

        public double DamageRate { get; }
        
        public double StrengthMultipler { get; }
        
        public double EnduranceMultipler { get; }

        public Storage Storage { get; }

        public abstract bool ProduceResourse();

        public bool StoreResourse(Storage storage)
        {
            return Storage.Move(Storage.ResourseBunches, storage);
        }
    }
}
