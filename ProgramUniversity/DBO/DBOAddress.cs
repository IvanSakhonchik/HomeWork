using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOAddress
    {
        public int idAddress { get; }
        public string street { get; }
        public string city { get; }
        public string building { get; }
        public DBOAddress(int idAddress, string street, string city, string building)
        {
            this.idAddress = idAddress;
            this.street = street;
            this.city = city;
            this.building = building;
        }
    }
}
