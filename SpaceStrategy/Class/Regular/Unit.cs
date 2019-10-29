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
            string name, double maxHealth, double health, double strength, double endurance,                                                                    // Unit
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding // Buildable
            )
            : base(
                  buildingState, timeToBuildSec, timeToDestroySec, resoursesForBuildingNeeded, storageForBuilding   // Buildable
                  )
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Health = health;
            this.Strength = strength;
            this.Endurance = endurance;
        }

        public string Name { get; }

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
            return $"{Name}: ({Health}, {Strength}, {Endurance})";
        }
    }
}
