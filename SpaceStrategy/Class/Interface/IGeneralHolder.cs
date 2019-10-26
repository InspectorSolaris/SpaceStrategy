using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IGeneralHolder<T>
    {
        string Name { get; }

        bool Add(T t);

        bool Add(List<T> ts);

        bool Move(T t, IGeneralHolder<T> generalHolder);

        bool Move(List<T> ts, IGeneralHolder<T> generalHolder);

        bool Remove(T t);

        bool Remove(List<T> ts);
    }
}
