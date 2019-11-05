using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Regular
{
    class ColonyType : BuildableType
    {
        public ColonyType
            (
            double maxResoursesOccupyingSpace, int maxStarShipsOccupyingSpace, int maxBuildingsOccupyingSpace,
            string name, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.MaxResoursesOccupyingSpace = maxResoursesOccupyingSpace;
            this.MaxStarShipsOccupyingSpace = maxStarShipsOccupyingSpace;
            this.MaxBuildingsOccupyingSpace = maxBuildingsOccupyingSpace;
        }

        public static ColonyType Create
            (
            Queue<string> args, List<ResourseBunch> necessaryResourses
            )
        {
            return new ColonyType(
                double.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                int.Parse(args.Dequeue()),
                args.Dequeue(),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                TimeSpan.FromSeconds(double.Parse(args.Dequeue())),
                necessaryResourses
                );
        }

        public double MaxResoursesOccupyingSpace { get; }

        public int MaxStarShipsOccupyingSpace { get; }

        public int MaxBuildingsOccupyingSpace { get; }

        public override string ToString()
        {
            return $"{Name} ({MaxResoursesOccupyingSpace}, {MaxStarShipsOccupyingSpace}, {MaxBuildingsOccupyingSpace}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
