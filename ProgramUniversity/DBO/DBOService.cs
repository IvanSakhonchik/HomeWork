using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOService
    {
        public string name { get;  }
        public int idUniversity { get; }
        public int idService { get; }
        public int idAddress { get; }
        public DBOService(string name, int idUniversity, int idService, int idAddress)
        {
            this.name = name;
            this.idUniversity = idUniversity;
            this.idService = idService;
            this.idAddress = idAddress;
        }
    }
}
