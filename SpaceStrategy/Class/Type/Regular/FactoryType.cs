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
    class FactoryType : ResourseBuildingType
    {
        public FactoryType
            (
            int rawResourseId, int productResourseId, double factoryRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Building.Type.Factory, occupyingSpace, maxUnitsOccupyingSpace,
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.RawResourseId = rawResourseId;
            this.ProductResourseId = productResourseId;
            this.FactoryRate = factoryRate;
        }

        public static FactoryType Create
            (
            Queue<string> args, List<ResourseBunch> necessaryResourses
            )
        {
            return new FactoryType(
                int.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                double.Parse(args.Dequeue()),
                double.Parse(args.Dequeue()),
                double.Parse(args.Dequeue()),
                double.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                args.Dequeue(),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                necessaryResourses
                );
        }

        public int RawResourseId { get; }

        public int ProductResourseId { get; }

        public double FactoryRate { get; }

        public override string ToString()
        {
            return $"{Name} ({RawResourseId}, {ProductResourseId}, {FactoryRate}, {DamageRate}, {StrengthMultipler}, {EnduranceMultipler}, {OccupyingSpace}, {MaxUnitsOccupyingSpace}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
