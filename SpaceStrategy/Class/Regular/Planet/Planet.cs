using System;
using System.Collections.Generic;
using System.Text;
using SpaceStrategy.Class.Abstract;
using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;

namespace SpaceStrategy.Class.Regular
{
    partial class Planet
    {
        public Planet
            (
            string name, ResourseHolder resourseHolder, SpaceObject spaceObject, ColonyHolder colonyHolder
            )
        {
            this.Name = name;
            this.ResourseHolder = resourseHolder;
            this.SpaceObject = spaceObject;
            this.ColonyHolder = colonyHolder;
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"{Name} ({(int)X}, {(int)Y}, {(int)Z})";
        }
    }
}
