using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOUniversity
    {
        public string name { get;}
        public int idUniversity { get;}
        public DBOUniversity(string name, int idUniversity)
        {
            this.name = name;
            this.idUniversity = idUniversity;
        }
    }
}
