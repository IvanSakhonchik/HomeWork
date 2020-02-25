using System;

namespace ParticalTask_14
{
    class Bird : IFlyable
    {
        public Coordinate Coordinate { get; set; }
        
        public Bird(Coordinate coordinate)
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
            Random rand = new Random();
            double distanceFromOnePointToAnotherPoint = Math.Sqrt(Math.Pow((Coordinate.X - coordinate.X), 2) + Math.Pow((Coordinate.Y - coordinate.Y), 2) + Math.Pow((Coordinate.Z - coordinate.Z), 2));
            return distanceFromOnePointToAnotherPoint / rand.Next(20);// speed of bird between 0-20 km/hours

        }
    }
}
