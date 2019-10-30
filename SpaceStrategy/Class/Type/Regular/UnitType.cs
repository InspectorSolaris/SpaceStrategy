using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Regular
{
    class UnitType : BuildableType
    {
        public UnitType
            (
            double maxHealth, double strength, double endurance,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.MaxHealth = maxHealth;
            this.Strength = strength;
            this.Endurance = endurance;
        }

        public double MaxHealth { get; }

        public double Strength { get; }

        public double Endurance { get; }

        public override string ToString()
        {
            return $"{Name} ({MaxHealth}, {Strength}, {Endurance}, {TimeToBuildSec.TotalSeconds}, {TimeToDestroySec.TotalSeconds})";
        }
    }
}
