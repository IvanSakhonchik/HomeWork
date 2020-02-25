using System;
using System.Collections.Generic;

namespace PracticalTask_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Bus bus1 = new Bus(10, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Bus bus2 = new Bus(5, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Bus bus3 = new Bus(1, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));

            Car car1 = new Car("BMW", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Car car2 = new Car("Opel", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Car car3 = new Car("Mercedes", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));

            Scooter scooter1 = new Scooter("Popov", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Scooter scooter2 = new Scooter("Mudry", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Scooter scooter3 = new Scooter("Helsing", new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));

            Truck truck1 = new Truck(15, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Truck truck2 = new Truck(20, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));
            Truck truck3 = new Truck(24, new Engine(300, 3, "A", "234AF"), new Chassis(8, "23424", 500), new Transmission("Light", 6, "WERT23"));

            vehicles.Add(bus1);
            vehicles.Add(bus2);
            vehicles.Add(bus3);
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(car3);
            vehicles.Add(scooter1);
            vehicles.Add(scooter2);
            vehicles.Add(scooter3);
            vehicles.Add(truck1);
            vehicles.Add(truck2);
            vehicles.Add(truck3);

            foreach(var veh in vehicles)
            {
                Console.WriteLine(veh);
            }

        }
    }
}
