using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Regular.Implementation;
using SpaceStrategy.Class.Type.Regular;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStrategy.Class.Regular
{
    class Factory : ResourseBuilding
    {
        public Factory
            (
            Resourse rawResourse, Resourse productResourse, double factoryRate,
            double damageRate, double strengthMultipler, double enduranceMultipler,
            int occupyingSpace, UnitHolder unitHolder,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  damageRate, strengthMultipler, enduranceMultipler,
                  Type.Factory, occupyingSpace, unitHolder,
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.RawResourse = rawResourse;
            this.ProductResourse = productResourse;
            this.FactoryRate = factoryRate;
        }

        public static Factory Create
            (
            FactoryType t, int ind
            )
        {
            return new Factory(
                GameState.Resourses[t.RawResourseId],
                GameState.Resourses[t.ProductResourseId],
                t.FactoryRate,
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
                $"Factory " + ind.ToString("D3"),
                State.Destroyed,
                t.TimeToBuildSec,
                t.TimeToDestroySec,
                t.NecessaryResourses
                );
        }

        public Resourse RawResourse { get; }

        public Resourse ProductResourse { get; }

        public double FactoryRate { get; }

        public override bool ProduceResourse(ResourseHolder resourseHolderForRaw, ResourseHolder resourseHolderForProduct)
        {
            if(!IsWorking || BuildingState != State.Builded)
            {
                return false;
            }

            double amount = 0;

            List<Unit> buildedUnits = Units.Where(u => u.BuildingState == State.Builded).ToList();

            buildedUnits.ForEach(u =>
            {
                amount += FactoryRate * (StrengthMultipler * u.Strength + EnduranceMultipler * u.Endurance);
            }
            );

            bool removed = resourseHolderForRaw.Remove(new ResourseBunch(RawResourse, amount));
            bool added = resourseHolderForProduct.Add(new ResourseBunch(ProductResourse, FactoryRate * amount));

            if(removed && added)
            {
                List<Unit> deadList = new List<Unit>();

                buildedUnits.ForEach(u =>
                {
                    u.Damage(DamageRate);

                    if(u.IsDead())
                    {
                        deadList.Add(u);
                    }
                }
                );

                Remove(deadList);

                return true;
            }
            if(removed)
            {
                resourseHolderForRaw.Add(new ResourseBunch(RawResourse, amount));
            }
            if(added)
            {
                resourseHolderForProduct.Remove(new ResourseBunch(ProductResourse, FactoryRate * amount));
            }

            return false;
        }
    }
}
