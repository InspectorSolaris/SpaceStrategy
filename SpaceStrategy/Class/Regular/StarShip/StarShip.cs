using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;

namespace SpaceStrategy.Class.Regular
{
    partial class StarShip : Buildable
    {
        public StarShip
            (
            double speed, ColonyHolder colonyHolder, SpaceObject spaceObject, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.Speed = speed;
            this.ColonyHolder = colonyHolder;
            this.SpaceObject = spaceObject;
            this.UnitHolder = unitHolder;
        }

        public double Speed { get; private set; }

        public async Task<bool> Colonize(Planet planet)
        {
            double dx = planet.X - X;
            double dy = planet.Y - Y;
            double dz = planet.Z - Z;

            double l = (dx * dx) + (dy * dy) + (dz * dz);
            double s = l / Speed;

            await Task.Delay(TimeSpan.FromSeconds(s));

            return Move(Colonies, planet);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
