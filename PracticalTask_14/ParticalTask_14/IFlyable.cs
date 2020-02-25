using System;
using System.Collections.Generic;
using System.Text;

namespace ParticalTask_14
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        double GetFlyTime(Coordinate coordinate);
    }
}
