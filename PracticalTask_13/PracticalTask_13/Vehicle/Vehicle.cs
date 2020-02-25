using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Vehicle
    {
        Engine Engine { get; set; }
        Chassis Chassis { get; set; }
        Transmission Transmission { get; set; }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
        public override string ToString()
        {
            return $"\tEngine: \n{Engine}\n\tChassis: \n{Chassis}\n\tTransmission: \n{Transmission}\n";
        }
    }
}
