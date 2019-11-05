using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStrategy.Class.Regular
{
    class Mine : ResourseBuilding
    {
        public Mine
            (
            Resourse miningResourse, double mineRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Type.Mine, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.MiningResourse = miningResourse;
            this.MineRate = mineRate;
        }

        public static Mine Create
            (
            MineType t, int ind
            )
        {
            return new Mine(
                GameState.Resourses[t.MiningResourseId],
                t.MineRate,
                t.DamageRate,
                t.StrengthMultipler,
                t.EnduranceMultipler,
                t.OccupyingSpace,
                new UnitHolder(
                    "UnitHolder",
                    t.MaxUnitsOccupyingSpace,
                    0,
                    new List<Unit>()
                    ),
                $"Mine " + ind.ToString("D3"),
                State.Destroyed,
                t.TimeToBuildSec,
                t.TimeToDestroySec,
                t.NecessaryResourses
                );
        }

        public Resourse MiningResourse { get; }

        public double MineRate { get; }

        public override bool ProduceResourse(ResourseHolder resourseHolderForRaw, ResourseHolder resourseHolderForProduct)
        {
            if(!IsWorking || BuildingState != State.Builded)
            {
                return false;
            }

            double amount = 0;

            List<Unit> deadList = new List<Unit>();
            List<Unit> buildedUnits = Units.Where(u => u.BuildingState == State.Builded).ToList();

            buildedUnits.ForEach(u =>
            {
                amount += MineRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance);
                u.Damage(DamageRate);

                if(u.IsDead())
                {
                    deadList.Add(u);
                }
            }
            );

            Remove(deadList);

            return resourseHolderForRaw.Move(new ResourseBunch(MiningResourse, amount), resourseHolderForProduct);
        }
    }
}
