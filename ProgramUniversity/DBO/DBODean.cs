using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class DBODean
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public int idFaculty { get; set; }
        public DBODean(string firstname, string lastname, int age, int idFaculty)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.idFaculty = idFaculty;
        }
    }
}
