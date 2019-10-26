using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Factory : ResourseBuilding
    {
        public Factory
            (
            Resourse rawResourse, Resourse productResourse, double factoryRate, Storage storageForRaw,                                                          // Factory
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
            this.RawResourse = rawResourse;
            this.ProductResourse = productResourse;
            this.FactoryRate = factoryRate;
            this.StorageForRaw = storageForRaw;
        }

        public Resourse RawResourse { get; }

        public Resourse ProductResourse { get; }

        public double FactoryRate { get; }

        public Storage StorageForRaw { get; }

        public bool StoreRawResourse(Storage storage)
        {
            return storage.Move(storage.ResourseBunches, StorageForRaw);
        }

        public override bool ProduceResourse()
        {
            double amount = 0;

            Units.ForEach(u => amount += FactoryRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance));

            bool removed = StorageForRaw.Remove(new ResourseBunch(RawResourse, amount));
            bool added = Storage.Add(new ResourseBunch(ProductResourse, FactoryRate * amount));

            if(removed && added)
            {
                return true;
            }
            if(removed)
            {
                StorageForRaw.Add(new ResourseBunch(RawResourse, amount));
            }
            if(added)
            {
                Storage.Remove(new ResourseBunch(ProductResourse, FactoryRate * amount));
            }

            return false;
        }
    }
}
