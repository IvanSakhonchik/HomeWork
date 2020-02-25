using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Transmission
    {
        public string Type { get; set; }
        public int Gears { get; set; }
        public string Number { get; set; }

        public Transmission(string type, int gears, string number)
        {
            Type = type;
            Gears = gears;
            Number = number;
        }

        public override string ToString()
        {
            return $"\tType: {Type}\tGears: {Gears}\tNumber: {Number}";
        }
    }
}
