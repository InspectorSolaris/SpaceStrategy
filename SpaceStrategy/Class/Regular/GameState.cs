using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class GameState
    {
        public GameState
            (
            List<Planet> planets, List<Colony> colonies
            )
        {
            this.Planets = planets;
            this.Colonies = colonies;
        }

        public List<Planet> Planets { get; private set; }

        public List<Colony> Colonies { get; private set; }
    }
}
