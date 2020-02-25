using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOFaculty
    {
        public string name { get; }
        public int idUniversity { get; }
        public int idFaculty { get; }
        public int idAddress { get; }
        public DBOFaculty(string name, int idUniversity, int idFaculty, int idAddress)
        {
            this.name = name;
            this.idUniversity = idUniversity;
            this.idFaculty = idFaculty;
            this.idAddress = idAddress;
        }

    }
}
