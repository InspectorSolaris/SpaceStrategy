using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class House : Building
    {
        public House
            (
            double healRate,                                                                                                                                    // House
            string name, Type buildingType, int occupyingSpace, int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units,                       // Building
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            )
            : base(
                  name, buildingType, occupyingSpace, maxUnitsOccupyingSpace, curUnitsOccupyingSpace, units,        // Building
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.HealRate = healRate;
        }

        public double HealRate { get; }

        public bool Heal()
        {
            bool healed = true;

            Units.ForEach(u => healed = healed && u.Health + HealRate <= u.MaxHealth);
            Units.ForEach(u => u.Heal((healed ? 1 : 0) * HealRate));

            return healed;
        }
    }
}
