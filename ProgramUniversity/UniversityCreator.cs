using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class UniversityCreator
    {
        public UniversityCreator()
        {
            
        }

        public University GetUniversity(IDBProvider provider)//method of creation of new university
        {
            University university = new University();//initialization of new university

            //Work with faculties
            List<Faculty> faculties = provider.GetFaculties();//list for faculties, which we get from DBProvider
            foreach (Faculty faculty in faculties)//adding faculties to a department list
            {
                university.AddDepartment(faculty);
            }

            //Work with institutes
            List<Institute> institutes = provider.GetInstitutes();//list for faculties, which we get from DBProvider
            foreach (Institute institute in institutes)//adding faculties to a department list
            {
                university.AddDepartment(institute);
            }

            //Work with services
            List<Service> services = provider.GetServices();//list for services, which we get from DBProvider
            foreach (Service service in services)//adding services to a department list
            {
                university.AddDepartment(service);
            }
            List<DBOFaculty> dBOFaculties = provider.GetDBOFaculties();

            List<DBOStudent> dBOStudents = provider.GetDBOStudents();

            List<DBODean> dBODeans = provider.GetDBODeans();

            university.DistributeDeans(dBODeans, dBOFaculties);
            university.DistributeStudents(dBOStudents, dBOFaculties);


            university.Output();//output of departments lists
            return university;
        }



    }
}
