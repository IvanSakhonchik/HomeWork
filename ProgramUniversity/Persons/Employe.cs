using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Employe : Person
    {
        int wage;
        string nameOfInstitute;

        public Employe(string firstname, string lastname, int age, int wage, string nameOfInstitute) : base(firstname, lastname, age)
        {
            this.wage = wage;
            this.nameOfInstitute = nameOfInstitute;
        }

        public string GetEmployesInstitute()
        {
            return nameOfInstitute;
        }
    }
}
