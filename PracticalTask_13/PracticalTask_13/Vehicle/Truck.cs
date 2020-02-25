using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Truck : Vehicle
    {
        public int Weight { get; set; }
        public Truck(int weight, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Truck:\n\tWeight:{Weight}\n" + base.ToString();
        }
    }
}
