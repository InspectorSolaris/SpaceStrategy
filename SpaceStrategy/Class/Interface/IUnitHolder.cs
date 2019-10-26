using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IUnitHolder : IGeneralHolder<Unit>
    {
        int MaxUnitsOccupyingSpace { get; }

        int CurUnitsOccupyingSpace { get; }

        List<Unit> Units { get; }
    }
}
