using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramUniversity
{
    class Person
    {
        string firstname;
        string lastname;
        int age;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            return firstname == (obj as Person).firstname && lastname == (obj as Person).lastname && age == (obj as Person).age;
        }
        public override string ToString()
        {
            return ($"{firstname}  {lastname}, age: {age}"); ;
        }
    }
}
