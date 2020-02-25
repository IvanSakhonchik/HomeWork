using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Department
    {
        public string name { get; }
        Adress adress;

        public Department(string name, Adress adress)
        {
            this.adress = adress;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            return (name == (obj as Department).name) && adress.Equals((obj as Department).adress);
        }

        public string GetNameOfDepartment()
        {
            return name;
        }

        public override string ToString()
        {
            return ($"Name: {name}, {adress}");
            
        }
    }
}
