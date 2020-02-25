using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Chassis
    {
        public int Wheels { get; set; }
        public string Number { get; set; }
        public int Carrying { get; set; }

        public Chassis(int wheels, string number, int carrying)
        {
            Wheels = wheels;
            Number = number;
            Carrying = carrying;
        }
        public override string ToString()
        {
            return $"\tWheels: {Wheels}\tCarrying: {Carrying}\tNumber: {Number}";
        }
    }
}
