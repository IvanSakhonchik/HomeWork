using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramUniversity
{
    class University
    {
        List<Department> departments = new List<Department>();
        //Motorcade motorcade = new Motorcade();

        public University()
        {
        }

        public bool AddDepartment(Department newDepartment)//method for adding departments to list
        {
            if (departments.Count > 9)
            {
                Console.Write("No more space for:  ");
                Console.WriteLine(newDepartment);
                Console.WriteLine("\n");
                return false;
            }

            foreach (Department dpt in departments)
            {
                if (dpt.Equals(newDepartment))
                {
                    Console.Write(newDepartment);
                    Console.WriteLine(" already exists.");
                    return false;
                }
            }

            departments.Add(newDepartment);
            return true;
        }
        public void DistributeDeans(List<DBODean> deans, List<DBOFaculty> faculties)//method for distribution deans among appropriate faculties
        {
            foreach (Department dpt in departments)
            {
                if (dpt.GetType() == typeof(Faculty))
                    foreach (DBOFaculty faculty in faculties)
                    {
                        foreach (DBODean dean in deans)
                        {
                            if (dpt.name == faculty.name && faculty.idFaculty == dean.idFaculty)
                            {
                                (dpt as Faculty).AddDean(new Dean(dean.firstname, dean.lastname, dean.age));

                            }
                        }
                    }


            }
        }

        public void DistributeStudents(List<DBOStudent> students, List<DBOFaculty> faculties)//method for distribution students among appropriate faculties
        {
            foreach (Department dpt in departments)
            {
                if (dpt.GetType() == typeof(Faculty))
                    foreach (DBOFaculty faculty in faculties)
                    {
                        foreach (DBOStudent student in students)
                        {
                            if (dpt.name == faculty.name && faculty.idFaculty ==  student.idFaculty)
                            {
                                (dpt as Faculty).AddStudent(new Student(student.firstname, student.lastname, student.age));
                            }
                        }
                    }
            }
        }


        public void Output()//method for outputting the departments list
        {
            Console.WriteLine("                 RESULT FOR UNIVERSITY");
            foreach (Department dpt in departments)
            {
                Console.WriteLine(dpt);
                if (dpt.GetType() == typeof(Faculty))
                {
                    (dpt as Faculty).Output();
                }
                if (dpt.GetType() == typeof(Institute))
                {
                    (dpt as Institute).Output();
                }
                if (dpt.GetType() == typeof(Service))
                {
                    (dpt as Service).Output();
                }
            }


            //motorcade.Output();
            //Console.WriteLine("\n\n");
        }
    }
}
