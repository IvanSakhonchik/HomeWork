using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Scooter : Vehicle
    {
        public string Name { get; set; }
        public Scooter(string name, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Scooter:\n\tName:{Name}\n" + base.ToString();
        }
    }
}
