using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBOStudent
    {
        public string firstname { get;  }
        public string lastname { get; }
        public int age { get; }
        public int idFaculty { get;  }
        public DBOStudent(string firstname, string lastname, int age, int idFaculty)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.idFaculty = idFaculty;
        }

    }
}
