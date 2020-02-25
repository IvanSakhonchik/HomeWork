using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    interface IDBProvider
    {
        List<Faculty> GetFaculties();
        List<Institute> GetInstitutes();
        List<Service> GetServices();
        List<DBOFaculty> GetDBOFaculties();
        List<DBOStudent> GetDBOStudents();
        List<DBODean> GetDBODeans();
    }
}
