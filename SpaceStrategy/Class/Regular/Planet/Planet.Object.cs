using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    partial class Planet : ISpaceObject
    {
        private SpaceObject SpaceObject { get; }

        public double X 
        {
            get
            {
                return SpaceObject.X;
            }
        }

        public double Y
        {
            get
            {
                return SpaceObject.Y;
            }
        }

        public double Z
        {
            get
            {
                return SpaceObject.Z;
            }
        }
    }
}
