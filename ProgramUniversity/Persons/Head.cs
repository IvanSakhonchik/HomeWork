using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Head : Person
    {
        int experience;
        string nameOfService;

        public Head(string firstname, string lastname, int age, int experience, string nameOfService) : base(firstname, lastname, age)
        {
            this.experience = experience;
            this.nameOfService = nameOfService;
        }
        public string GetHeadsService()//method to get Managers Institute
        {
            return nameOfService;
        }
    }
}
