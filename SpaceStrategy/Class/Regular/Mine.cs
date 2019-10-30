using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Mine : ResourseBuilding
    {
        public Mine
            (
            Resourse miningResourse, double mineRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Type.Mine, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.MiningResourse = miningResourse;
            this.MineRate = mineRate;
        }

        public Resourse MiningResourse { get; }

        public double MineRate { get; }

        public override bool ProduceResourse(ResourseHolder resourseHolderForRaw, ResourseHolder resourseHolderForProduct)
        {
            if(!IsWorking)
            {
                return false;
            }

            double amount = 0;

            Units.ForEach(u => amount += MineRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance));

            return resourseHolderForRaw.Move(new ResourseBunch(MiningResourse, amount), resourseHolderForProduct);
        }
    }
}
