using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Colony : Buildable
    {
        public Colony
            (
            ResourseHolder resourseHolder, StarShipHolder starShipHolder, BuildingHolder buildingHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.ResourseHolder = resourseHolder;
            this.StarShipHolder = starShipHolder;
            this.BuildingHolder = buildingHolder;
        }

        public override string ToString()
        {
            return $"{Name} ({BuildingState})";
        }
    }
}
