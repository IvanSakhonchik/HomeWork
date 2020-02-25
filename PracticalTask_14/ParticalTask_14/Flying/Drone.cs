using System;
using System.Collections.Generic;
using System.Text;

namespace ParticalTask_14
{
    class Drone : IFlyable
    {
        public Coordinate Coordinate { get; set; }
        public Drone(Coordinate coordinate)
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
            double currentDistance = 0;
            double timeFromOnePointToAnotherPoint = 0;
            while (currentDistance < distanceFromOnePointToAnotherPoint)
            {
                currentDistance += 10; // because drone speed 60 km/hours => 10 km/min. 11 min - 10 km, because 1 min he's freezing
                timeFromOnePointToAnotherPoint += 11; 
            }
            timeFromOnePointToAnotherPoint += (currentDistance - distanceFromOnePointToAnotherPoint); //add last timeFromOnePointToAnotherPoint
            return timeFromOnePointToAnotherPoint / 60;
        }
    }
}
