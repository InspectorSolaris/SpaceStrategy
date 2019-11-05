using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class Resourse
    {
        public Resourse
            (
            int id, string name, string description
            )
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public static Resourse Create
            (
            Queue<string> args
            )
        {
            return new Resourse(
                int.Parse(args.Dequeue()),
                args.Dequeue(),
                args.Dequeue()
                );
        }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }
    }
}
