using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Interface
{
    interface IStarShipHolder : IGeneralHolder<StarShip>
    {
        int MaxStarShipsOccupyingSpace { get; }

        int CurStarShipsOccupyingSpace { get; }

        List<StarShip> StarShips { get; }
    }
}
