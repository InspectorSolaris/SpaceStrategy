using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IResourseHolder : IGeneralHolder<ResourseBunch>
    {
        double MaxResoursesOccupyingSpace { get; }

        double CurResoursesOccupyingSpace { get; }

        List<ResourseBunch> ResourseBunches { get; }
    }
}
