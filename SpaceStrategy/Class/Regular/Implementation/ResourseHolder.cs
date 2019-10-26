using SpaceStrategy.Class.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStrategy.Class.Regular.Implementation
{
    class ResourseHolder : IResourseHolder
    {
        public string Name { get; }

        public double MaxResoursesOccupyingSpace { get; }

        public double CurResoursesOccupyingSpace { get; private set; }

        public List<ResourseBunch> ResourseBunches { get; }















        private void AddSingle(ResourseBunch t)
        {
            CurResoursesOccupyingSpace += t.Amount;

            if(ResourseBunches.Exists(r => r.Resourse.Id == t.Resourse.Id))
            {
                ResourseBunches.Find(r => r.Resourse.Id == t.Resourse.Id).Add(t.Amount);
            }
            else
            {
                ResourseBunches.Add(t);
            }
        }

        private void RemoveSingle(ResourseBunch t)
        {
            ResourseBunch resourseBunch = ResourseBunches.Find(r => r.Resourse.Id == t.Resourse.Id);

            resourseBunch.Remove(t.Amount);

            if(resourseBunch.Amount <= 0)
            {
                ResourseBunches.Remove(resourseBunch);
            }

            CurResoursesOccupyingSpace -= t.Amount;
        }

        private bool IsEnoughSpace(ResourseBunch t)
        {
            return CurResoursesOccupyingSpace + t.Amount <= MaxResoursesOccupyingSpace;
        }

        private bool IsEnoughSpace(List<ResourseBunch> ts)
        {
            double sum = 0;

            ts.ForEach(t => sum += t.Amount);

            return CurResoursesOccupyingSpace + sum <= MaxResoursesOccupyingSpace;
        }

        private bool Contains(ResourseBunch t)
        {
            return ResourseBunches.Exists(r => r.Resourse.Id == t.Resourse.Id);
        }

        private bool Contains(List<ResourseBunch> ts)
        {
            bool contains = true;

            ts.ForEach(t => contains = contains && ResourseBunches.Exists(r => r.Resourse.Id == t.Resourse.Id));

            return contains;
        }















        public bool Add(ResourseBunch t)
        {
            if(IsEnoughSpace(t))
            {
                AddSingle(t);

                return true;
            }

            return false;
        }

        public bool Add(List<ResourseBunch> ts)
        {
            if(IsEnoughSpace(ts))
            {
                ts.ForEach(t => AddSingle(t));

                return true;
            }

            return false;
        }

        public bool Move(ResourseBunch t, IGeneralHolder<ResourseBunch> generalHolder)
        {
            if(Contains(t) &&
                generalHolder.Add(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Move(List<ResourseBunch> ts, IGeneralHolder<ResourseBunch> generalHolder)
        {
            if(Contains(ts) &&
                generalHolder.Add(ts))
            {
                Remove(ts);

                return true;
            }

            return false;
        }

        public bool Remove(ResourseBunch t)
        {
            if(Contains(t))
            {
                RemoveSingle(t);

                return true;
            }

            return false;
        }

        public bool Remove(List<ResourseBunch> ts)
        {
            if(Contains(ts))
            {
                ts.ForEach(t => RemoveSingle(t));

                return true;
            }

            return false;
        }
    }
}
