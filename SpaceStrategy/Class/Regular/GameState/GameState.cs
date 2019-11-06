using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using SpaceStrategy.Class.Regular.Implementation;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SpaceStrategy.Class.Regular
{
    partial class GameState
    {
        public GameState
            (
            List<Planet> planets
            )
        {
            InitData();

            this.Planets = planets;
        }
        
        private static bool Initialized { get; set; }

        public List<Planet> Planets { get; }

        public static Random Random { get; } = new Random();

        public static GameState GenerateNew
            (
            int maxAmount = 8,
            int minAmount = 4,
            int maxCol = 1000000,
            double maxX = 1000,
            double maxY = 1000,
            double maxZ = 1000
            )
        {
            InitData();

            maxAmount = Math.Min(128, maxAmount);
            minAmount = Math.Max(001, minAmount);

            List<Planet> planets = new List<Planet>();

            for(int i = 0; i < Random.Next(minAmount, maxAmount); ++i)
            {
                List<ResourseBunch> planetResourseBunches = new List<ResourseBunch>();

                Resourses.ForEach(r => planetResourseBunches.Add(new ResourseBunch(r, Random.Next(1000, 1000000))));

                planets.Add(
                    new Planet(
                        $"Planet " + (i + 1).ToString("D3"),
                        new ResourseHolder(
                            $"Planet " + (i + 1).ToString("D3") + " ResourseHolder",
                            1000000,
                            planetResourseBunches.Sum(x => x.Amount),
                            planetResourseBunches
                            ),
                        new SpaceObject(
                            maxX * Random.NextDouble(),
                            maxY * Random.NextDouble(),
                            maxZ * Random.NextDouble()
                            ),
                        new ColonyHolder(
                            $"Planet " + (i + 1).ToString("D3") + " ColonyHolder",
                            maxCol * Random.Next(),
                            0,
                            new List<Colony>()
                            )
                        )
                    );
            }

            string colonyName = "Main Colony";

            List<ResourseBunch> colonyResourseBunches = new List<ResourseBunch>();

            Resourses.ForEach(r => colonyResourseBunches.Add(new ResourseBunch(r, 100)));

            planets[0].Colonies.Add(
                new Colony(
                    new ResourseHolder(
                        $"{colonyName} ResourseHolder",
                        colonyResourseBunches.Sum(x => x.Amount) * 2,
                        colonyResourseBunches.Sum(x => x.Amount),
                        colonyResourseBunches
                        ),
                    new StarShipHolder(
                        $"{colonyName} StarShipHolder",
                        2,
                        0,
                        new List<StarShip>()
                        ),
                    new BuildingHolder(
                        $"{colonyName} BuildingHolder",
                        100,
                        0,
                        new List<Building>()
                        ),
                    colonyName,
                    Buildable.State.Builded,
                    TimeSpan.FromSeconds(0),
                    TimeSpan.FromSeconds(0),
                    null
                    )
                );

            return new GameState(planets);
        }

        public void  GameTick()
        {
            foreach(Planet p in Planets)
            {
                foreach(Colony c in p.Colonies)
                {
                    foreach(Building b in c.Buildings)
                    {
                        b.BuildingWork(p.ResourseHolder, c.ResourseHolder);
                    }
                }
            }
        }
    }
}
