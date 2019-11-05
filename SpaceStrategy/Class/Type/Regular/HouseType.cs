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
    class HouseType : BuildingType
    {
        public HouseType
            (
            double healRate,
            int occupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  Building.Type.House, occupyingSpace, maxUnitsOccupyingSpace,
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.HealRate = healRate;
        }

        public static HouseType Create
            (
            Queue<string> args, List<ResourseBunch> necessaryResourses
            )
        {
            return new HouseType(
                double.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                args.Dequeue(),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                necessaryResourses
                );
        }

        public double HealRate { get; }

        public override string ToString()
        {
            return $"{Name} ({HealRate}, {OccupyingSpace}, {MaxUnitsOccupyingSpace}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
