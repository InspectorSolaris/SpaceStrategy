using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace SpaceStrategy.Class.Regular
{
    partial class GameState
    {
        public GameState
            (
            List<Planet> planets
            )
        {
            this.Planets = planets;
        }
        
        public List<Planet> Planets { get; }

        public static Random Random { get; } = new Random();

        public static GameState GenerateNew
            (
            int maxAmount = 21,
            int minAmount = 10,
            int maxCol = 1000000,
            double maxRes = 1000000,
            double maxX = 1000,
            double maxY = 1000,
            double maxZ = 1000
            )
        {
            maxAmount = Math.Min(128, maxAmount);
            minAmount = Math.Max(001, minAmount);

            List<Planet> planets = new List<Planet>(Random.Next(minAmount, maxAmount));

            for(int i = 0; i < planets.Capacity; ++i)
            {
                List<ResourseBunch> planetResourseBunches = new List<ResourseBunch>();

                Resourses.ForEach(r => planetResourseBunches.Add(new ResourseBunch(r, Random.Next(1000, 1000000))));

                planets.Add(new Planet(
                    maxX * Random.NextDouble(),
                    maxY * Random.NextDouble(),
                    maxZ * Random.NextDouble(),
                    maxRes * Random.NextDouble(),
                    planetResourseBunches.Sum(x => x.Amount),
                    planetResourseBunches,
                    maxCol * Random.Next(),
                    0,
                    new List<Colony>(),
                    $"Planet " + (i + 1).ToString("D3")
                    ));
            }

            List<ResourseBunch> colonyResourseBunches = new List<ResourseBunch>();

            Resourses.ForEach(r => colonyResourseBunches.Add(new ResourseBunch(r, 100)));

            List<Building> colonyBuildings = new List<Building>
            {
                new Storage(
                    100,
                    colonyResourseBunches.Sum(x => x.Amount),
                    colonyResourseBunches,
                    "Main Colony Storage",
                    Building.Type.Storage,
                    10,
                    5,
                    0,
                    new List<Unit>(),
                    Buildable.State.Builded,
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(5),
                    new List<ResourseBunch>(),
                    null
                    )
            };

            planets[0].Colonies.Add(
                new Colony(
                    "Main Colony",
                    100,
                    colonyBuildings.Sum(x => x.OccupyingSpace),
                    colonyBuildings,
                    2,
                    0,
                    new List<StarShip>()
                    )
                );

            return new GameState(planets);
        }
    }
}
