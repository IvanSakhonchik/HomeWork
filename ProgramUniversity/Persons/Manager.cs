using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Manager : Person
    {
        int roomnumber;
        string nameOfInstitute;
        public Manager(string firstname, string lastname, int age, int roomnumber, string nameOfInstitute) : base(firstname, lastname, age)
        {
            this.roomnumber = roomnumber;
            this.nameOfInstitute = nameOfInstitute;
        }

        public string GetManagersInstitute()//method to get Managers Institute
        {
            return nameOfInstitute;
        }
    }
}
