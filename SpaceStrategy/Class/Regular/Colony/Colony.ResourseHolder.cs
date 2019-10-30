using SpaceStrategy.Class.Interface;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Regular
{
    partial class Colony : IResourseHolder
    {
        public ResourseHolder ResourseHolder { get; }

        public double MaxResoursesOccupyingSpace
        {
            get
            {
                return ResourseHolder.MaxResoursesOccupyingSpace;
            }
        }

        public double CurResoursesOccupyingSpace
        {
            get
            {
                return ResourseHolder.CurResoursesOccupyingSpace;
            }
        }

        public List<ResourseBunch> ResourseBunches
        {
            get
            {
                return ResourseHolder.ResourseBunches;
            }
        }

        public bool Add(ResourseBunch t)
        {
            return ResourseHolder.Add(t);
        }

        public bool Add(List<ResourseBunch> ts)
        {
            return ResourseHolder.Add(ts);
        }

        public bool Move(ResourseBunch t, IGeneralHolder<ResourseBunch> generalHolder)
        {
            return ResourseHolder.Move(t, generalHolder);
        }

        public bool Move(List<ResourseBunch> ts, IGeneralHolder<ResourseBunch> generalHolder)
        {
            return ResourseHolder.Move(ts, generalHolder);
        }

        public bool Remove(ResourseBunch t)
        {
            return ResourseHolder.Remove(t);
        }

        public bool Remove(List<ResourseBunch> ts)
        {
            return ResourseHolder.Remove(ts);
        }
    }
}
