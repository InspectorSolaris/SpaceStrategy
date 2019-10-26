using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;

namespace SpaceStrategy.Class.Regular
{
    partial class StarShip : Buildable
    {
        public StarShip
            (
            int maxUnitsOccupyingSpace, int curUnitsOccupyingSpace, List<Unit> units, string name, double speed, double x, double y, double z, int maxColoniesOccupyingSpace, int curColoniesOccupyingSpace, List<Colony> colonies, // StarShip
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding                                                                     // Buildable
            )
            : base(
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.MaxUnitsOccupyingSpace = maxUnitsOccupyingSpace;
            this.CurUnitsOccupyingSpace = curUnitsOccupyingSpace;
            this.Units = units;
            this.Name = name;
            this.Speed = speed;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.MaxColoniesOccupyingSpace = maxColoniesOccupyingSpace;
            this.CurColoniesOccupyingSpace = curColoniesOccupyingSpace;
            this.Colonies = colonies;
        }

        public string Name { get; }
        
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
    }
}
