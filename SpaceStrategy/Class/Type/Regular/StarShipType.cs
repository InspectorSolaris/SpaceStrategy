using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Regular
{
    class StarShipType : BuildableType
    {
        public StarShipType
            (
            double speed, int maxColoniesOccupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.Speed = speed;
            this.MaxColoniesOccupyingSpace = maxColoniesOccupyingSpace;
            this.MaxUnitsOccupyingSpace = maxUnitsOccupyingSpace;
        }

        public static StarShipType Create
            (
            Queue<string> args, List<ResourseBunch> necessaryResourses
            )
        {
            return new StarShipType(
                double.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                args.Dequeue(),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                necessaryResourses
                );
        }

        public double Speed { get; }

        public int MaxColoniesOccupyingSpace { get; }

        public int MaxUnitsOccupyingSpace { get; }

        public override string ToString()
        {
            return $"{Name} ({Speed}, {MaxUnitsOccupyingSpace}, {MaxColoniesOccupyingSpace}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
