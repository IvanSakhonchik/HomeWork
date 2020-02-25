using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Adress
    {
        string street;
        string city;
        string building;

        public Adress(string street, string city, string building)
        {
            this.street = street;
            this.city = city;
            this.building = building;
        }

        public override string ToString()
        {
            return $"adress: {street}, {city}, {building}";  
        }

        public override bool Equals(object obj)
        {
            return (street == (obj as Adress).street) && (city == (obj as Adress).city) && (building == (obj as Adress).building);
        }
    }
}
