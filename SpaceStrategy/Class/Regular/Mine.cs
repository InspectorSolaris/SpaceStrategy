using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Mine : ResourseBuilding
    {
        public Mine(
            Resourse miningResourse, double mineRate,                                                                                                           // Mine
            double damageRate, double strengthMultipler, double enduranceMultipler, Storage storage,                                                            // ResourseBuilding                                                                                                   // House constructor
            string name, Type buildingType, int occupyingSpace, int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units,                       // Building
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler, storage,                                       // ResourseBuilding
                  name, buildingType, occupyingSpace, maxUnitsOccupyingSpace, curUnitsOccupyingSpace, units,        // Building
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.MiningResourse = miningResourse;
            this.MineRate = mineRate;
        }

        public Resourse MiningResourse { get; }

        public double MineRate { get; }

        public override bool ProduceResourse()
        {
            double amount = 0;

            Units.ForEach(u => amount += MineRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance));

            return Storage.Add(new ResourseBunch(MiningResourse, amount));
        }
    }
}
