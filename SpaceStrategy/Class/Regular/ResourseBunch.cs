using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular
{
    class ResourseBunch
    {
        public ResourseBunch
            (
            Resourse resourse, double amount
            )
        {
            this.Resourse = resourse;
            this.Amount = amount;
        }

        public Resourse Resourse { get; }

        public double Amount { get; private set; }

        public void Add(double amount)
        {
            Amount += amount;
        }
        
        public void Remove(double amount)
        {
            Amount -= amount;
        }
    }
}
