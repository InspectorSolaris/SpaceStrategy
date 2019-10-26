﻿using System;
using System.Collections.Generic;
using System.Text;
using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;

namespace SpaceStrategy.Class.Regular
{
    partial class Planet
    {
        public Planet
            (
            double x, double y, double z, double maxResoursesOccupyingSpace, double curResoursesOccupyingSpace, List<ResourseBunch> resourseBunches, int maxColoniesOccupyingSpace, int curColoniesOccupyingSpace, List<Colony> colonies, string name
            )
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.MaxResoursesOccupyingSpace = maxResoursesOccupyingSpace;
            this.CurResoursesOccupyingSpace = curResoursesOccupyingSpace;
            this.ResourseBunches = resourseBunches;
            this.MaxColoniesOccupyingSpace = maxColoniesOccupyingSpace;
            this.CurColoniesOccupyingSpace = curColoniesOccupyingSpace;
            this.Colonies = colonies;
            this.Name = name;
        }

        public string Name { get; }
    }
}
