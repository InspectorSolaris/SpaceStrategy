using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Unit : Buildable
    {
        public Unit
            (
            double maxHealth, double strength, double endurance,
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
            : base(
                  name, buildingState, timeToBuildSec, timeToDestroySec, necessaryResourses
                  )
        {
            this.MaxHealth = maxHealth;
            this.Health = maxHealth;
            this.Strength = strength;
            this.Endurance = endurance;
        }

        public double MaxHealth { get; }

        public double Health { get; private set; }

        public double Strength { get; }

        public double Endurance { get; }

        public void Heal
            (
            double healRate
            )
        {
            if(Health > 0)
            {
                Health += healRate;
                Health = Math.Min(Health, MaxHealth);
            }
        }

        public void Damage
            (
            double damageRate
            )
        {
            if(Health > 0)
            {
                Health -= damageRate;
            }
        }

        public bool IsDead()
        {
            return Health <= 0;
        }

        public override string ToString()
        {
            return $"{Name}: ({Health}, {Strength}, {Endurance}) ({BuildingState})";
        }
    }
}
