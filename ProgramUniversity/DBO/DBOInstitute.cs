using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOInstitute
    {
        public string name { get; }
        public int idUniversity { get;}
        public int idInstitute { get; }
        public int idAddress { get; }
        public DBOInstitute(string name, int idUniversity, int idInstitute, int idAddress)
        {
            this.name = name;
            this.idUniversity = idUniversity;
            this.idInstitute = idInstitute;
            this.idAddress = idAddress;
        }
    }
}
