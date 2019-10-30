using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class ResourseBuilding : Building
    {
        protected ResourseBuilding
            (
            double damageRate, double strengthMultipler, double enduranceMultipler,
            Type buildingType, int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  buildingType, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.DamageRate = damageRate;
            this.StrengthMultipler = strengthMultipler;
            this.EnduranceMultipler = enduranceMultipler;
        }

        public bool IsWorking { get; protected set; }

        public double DamageRate { get; }
        
        public double StrengthMultipler { get; }
        
        public double EnduranceMultipler { get; }

        public abstract bool ProduceResourse(ResourseHolder resourseHolderForRaw, ResourseHolder resourseHolderForProduct);

        public void ChangeIsWorkingState()
        {
            IsWorking = !IsWorking;
        }
    }
}
