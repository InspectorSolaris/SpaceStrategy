using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Regular
{
    class MineType : ResourseBuildingType
    {
        public MineType
            (
            int miningResourseId, double mineRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Building.Type.Mine, occupyingSpace, maxUnitsOccupyingSpace,
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.MiningResourseId = miningResourseId;
            this.MineRate = mineRate;
        }

        public int MiningResourseId { get; }

        public double MineRate { get; }

        public override string ToString()
        {
            return $"{Name} ({MiningResourseId}, {MineRate}, {DamageRate}, {StrengthMultipler}, {EnduranceMultipler}, {OccupyingSpace}, {MaxUnitsOccupyingSpace}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
