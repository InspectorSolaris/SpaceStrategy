using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Type.Abstract
{
    abstract class BuildingType : BuildableType
    {
        public BuildingType
            (
            Building.Type type, int occupyingSpace, int maxUnitsOccupyingSpace,
            string name, TimeSpan timeToBuild, TimeSpan timeToDestroy, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, timeToBuild, timeToDestroy, necessaryResourses
                  )
        {
            this.Type = type;
            this.OccupyingSpace = occupyingSpace;
            this.MaxUnitsOccupyingSpace = maxUnitsOccupyingSpace;
        }

        public Building.Type Type { get; }

        public int OccupyingSpace { get; }

        public int MaxUnitsOccupyingSpace { get; }

        public override string ToString()
        {
            string result = "Unknown";

            switch(Type)
            {
                case Building.Type.House:
                    result = ((HouseType)this).ToString();
                    break;
                case Building.Type.Mine:
                    result = ((MineType)this).ToString();
                    break;
                case Building.Type.Factory:
                    result = ((FactoryType)this).ToString();
                    break;
            }

            return result;
        }
    }
}
