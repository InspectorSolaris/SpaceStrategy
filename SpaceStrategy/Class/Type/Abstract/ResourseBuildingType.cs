using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Abstract
{
    abstract class ResourseBuildingType : BuildingType
    {
        protected ResourseBuildingType
            (
            double damageRate, double strengthMultipler, double enduranceMultipler,
            Building.Type type, int occupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  type, occupyingSpace, maxUnitsOccupyingSpace,
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.DamageRate = damageRate;
            this.StrengthMultipler = strengthMultipler;
            this.EnduranceMultipler = enduranceMultipler;
        }

        public double DamageRate { get; }

        public double StrengthMultipler { get; }

        public double EnduranceMultipler { get; }
    }
}
