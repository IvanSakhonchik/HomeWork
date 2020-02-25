using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Car : Vehicle
    {
        public string Mark { get; set; }
        public Car( string mark, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Mark = mark;
        }
        public override string ToString()
        {
            return $"Car:\n\tMark:{Mark}\n" + base.ToString();
        }
    }
}
