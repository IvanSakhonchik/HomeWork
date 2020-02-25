using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramUniversity
{
    class Faculty : Department
    {
        List<Student> students = new List<Student>();
        Dean dean;


        public Faculty(string name, Adress adress) : base(name, adress)//создание объекта базового класса
        {
        }

        public bool AddStudent(Student newStudent)
        {
            if (students.Count > 9)
            {
                Console.Write("No more space in list of student for:  ");
                Console.WriteLine(newStudent);
                Console.WriteLine("\n");
                return false;
            }

            foreach (Student std in students)
            {
                if (std.Equals(newStudent))
                {
                    Console.Write(newStudent);
                    Console.WriteLine(" already exists among students.");
                    return false;
                }
            }

            students.Add(newStudent);
            return true;
        }

        public bool AddDean(Dean dean)
        {
            this.dean = dean;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $"   under the direction of Dean: {dean}";

        }
        public void Output()
        {
            Console.WriteLine("          RESULT FOR FACULTY ");
            foreach (Student std in students)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine("\n\n");
        }
    }
}
