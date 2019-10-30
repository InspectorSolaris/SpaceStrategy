using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Abstract
{
    abstract class BuildableType
    {
        public BuildableType
            (
            string name, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
        {
            this.Name = name;
            this.TimeToBuildSec = timeToBuildSec;
            this.TimeToDestroySec = timeToDestroySec;
            this.NecessaryResourses = necessaryResourses;
        }

        public string Name { get; }

        public TimeSpan TimeToBuildSec { get; }

        public TimeSpan TimeToDestroySec { get; }

        public List<ResourseBunch> NecessaryResourses { get; }
    }
}
