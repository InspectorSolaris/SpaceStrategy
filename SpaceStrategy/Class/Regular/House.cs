using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class House : Building
    {
        public House
            (
            double healRate,
            int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  Type.House, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.HealRate = healRate;
        }

        public static House Create
            (
            HouseType t, int ind
            )
        {
            return new House(
                t.HealRate,
                t.OccupyingSpace,
                new UnitHolder(
                    "UnitHolder",
                    t.MaxUnitsOccupyingSpace,
                    0,
                    new List<Unit>()
                    ),
                $"House " + ind.ToString("D3"),
                Buildable.State.Destroyed,
                t.TimeToBuildSec,
                t.TimeToDestroySec,
                t.NecessaryResourses
                );
        }

        public double HealRate { get; }

        public bool Heal()
        {
            bool healed = true;

            Units.ForEach(u => healed = healed && u.Health + HealRate <= u.MaxHealth);
            Units.ForEach(u => u.Heal((healed ? 1 : 0) * HealRate));

            return healed;
        }
    }
}
