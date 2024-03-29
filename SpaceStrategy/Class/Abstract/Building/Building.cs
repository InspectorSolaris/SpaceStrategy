﻿using System;
using System.Collections.Generic;
using System.Text;
using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class Building : Buildable
    {
        protected Building
            (
            Type buildingType, int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.BuildingType = buildingType;
            this.OccupyingSpace = occupyingSpace;
            this.UnitHolder = unitHolder;
        }

        public enum Type
        {
            House,
            Mine,
            Factory
        }

        public Type BuildingType { get; protected set; }

        public int OccupyingSpace { get; }

        public void BuildingWork(ResourseHolder p, ResourseHolder c)
        {
            switch(BuildingType)
            {
                case Type.House:
                    ((House)this).Heal();
                    break;
                case Type.Mine:
                    ((Mine)this).ProduceResourse(p, c);
                    break;
                case Type.Factory:
                    ((Factory)this).ProduceResourse(c, c);
                    break;
            }
        }

        public override string ToString()
        {
            string result = "Unknown";

            if(BuildingType != Type.House)
            {
                result = $"{Name} ({BuildingState}, {((ResourseBuilding)this).IsWorking})";
            }
            else
            {
                result = $"{Name} ({BuildingState})";
            }

            return result;
        }
    }
}
