using System;
using System.Collections.Generic;
using System.Text;

namespace ParticalTask_14
{
    class Airplane : IFlyable
    {
        public Coordinate Coordinate { get; set; }
        public Airplane(Coordinate coordinate)
        {
            Coordinate = coordinate;

        }
        public void FlyTo(Coordinate coordinate)
        {
            Coordinate.X = coordinate.X;
            Coordinate.Y = coordinate.Y;
            Coordinate.Z = coordinate.Z;
        }
        public double GetFlyTime(Coordinate coordinate)
        {
            double distanceFromOnePointToAnotherPoint = Math.Sqrt(Math.Pow((Coordinate.X - coordinate.X), 2) + Math.Pow((Coordinate.Y - coordinate.Y), 2) + Math.Pow((Coordinate.Z - coordinate.Z), 2));
            return Math.Sqrt(2 * distanceFromOnePointToAnotherPoint / 100); // move with acceleration 100 km/hours
        }
    }
}
