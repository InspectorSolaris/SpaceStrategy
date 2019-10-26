using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IColonyHolder : IGeneralHolder<Colony>
    {
        int MaxColoniesOccupyingSpace { get; }

        int CurColoniesOccupyingSpace { get; }

        List<Colony> Colonies { get; }
    }
}
