using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Booker : Person
    {
        string post;
        string nameOfService;
        public Booker(string firstname, string lastname, int age, string post, string nameOfService) : base(firstname, lastname, age)
        {
            this.post = post;
            this.nameOfService = nameOfService; 
        }

        public string GetBookersService()//method to get bookers Service
        {
            return nameOfService;
        }
    }
}
