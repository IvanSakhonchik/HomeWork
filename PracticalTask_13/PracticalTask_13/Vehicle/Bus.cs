using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Bus : Vehicle
    {
        public int Passengers { get; set; }
        public Bus(int passengers, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Passengers = passengers;
        }
        public override string ToString()
        {
            return $"Bus:\n\tPassengers:{Passengers}\n"+ base.ToString();
        }
    }
}
