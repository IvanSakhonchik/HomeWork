using System;

namespace ParticalTask_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(new Coordinate(100, 100, 100));
            Bird bird = new Bird(new Coordinate(100, 100, 100));
            Drone drone = new Drone(new Coordinate(100, 100, 100));

            Console.WriteLine("Time of airplane :{0}",airplane.GetFlyTime(new Coordinate(400, 400, 400)));
            Console.WriteLine("Time of bird :{0}", bird.GetFlyTime(new Coordinate(400, 400, 400)));
            Console.WriteLine("Time of drone :{0}\n", drone.GetFlyTime(new Coordinate(400, 400, 400)));

            airplane.FlyTo(new Coordinate(200, 200, 200));
            bird.FlyTo(new Coordinate(200, 200, 200));
            drone.FlyTo(new Coordinate(200, 200, 200));

            Console.WriteLine("Time of airplane :{0}", airplane.GetFlyTime(new Coordinate(400, 400, 400)));
            Console.WriteLine("Time of bird :{0}", bird.GetFlyTime(new Coordinate(400, 400, 400)));
            Console.WriteLine("Time of drone :{0}", drone.GetFlyTime(new Coordinate(400, 400, 400)));
        }
    }
}
