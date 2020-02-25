using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTask_13
{
    class Engine
    {
        public int Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }

        public Engine(int power, int volume, string type, string number)
        {
            Power = power;
            Volume = volume;
            Type = type;
            Number = number;
        }
        public override string ToString()
        {
            return $"\tPower: {Power}\tVolume: {Volume}\tType: {Type}\tNumber: {Number}";
        }
    }
}
