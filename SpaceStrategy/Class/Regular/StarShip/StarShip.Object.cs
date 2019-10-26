using SpaceStrategy.Class.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class StarShip : IObject
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }
    }
}
