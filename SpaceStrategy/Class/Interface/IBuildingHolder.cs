using SpaceStrategy.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IBuildingHolder : IGeneralHolder<Building>
    {
        int MaxBuildingsOccupyingSpace { get; }

        int CurBuildingsOccupyingSpace { get; }

        List<Building> Buildings { get; }
    }
}
