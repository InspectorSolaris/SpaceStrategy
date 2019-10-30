using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Factory : ResourseBuilding
    {
        public Factory
            (
            Resourse rawResourse, Resourse productResourse, double factoryRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Type.Factory, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.RawResourse = rawResourse;
            this.ProductResourse = productResourse;
            this.FactoryRate = factoryRate;
        }

        public Resourse RawResourse { get; }

        public Resourse ProductResourse { get; }

        public double FactoryRate { get; }

        public override bool ProduceResourse(ResourseHolder resourseHolderForRaw, ResourseHolder resourseHolderForProduct)
        {
            if(!IsWorking)
            {
                return false;
            }

            double amount = 0;

            Units.ForEach(u => amount += FactoryRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance));

            bool removed = resourseHolderForRaw.Remove(new ResourseBunch(RawResourse, amount));
            bool added = resourseHolderForProduct.Add(new ResourseBunch(ProductResourse, FactoryRate * amount));

            if(removed && added)
            {
                return true;
            }
            if(removed)
            {
                resourseHolderForRaw.Add(new ResourseBunch(RawResourse, amount));
            }
            if(added)
            {
                resourseHolderForProduct.Remove(new ResourseBunch(ProductResourse, FactoryRate * amount));
            }

            return false;
        }
    }
}
