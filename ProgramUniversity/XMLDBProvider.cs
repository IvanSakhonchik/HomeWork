using System.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class XMLDBProvider : IDBProvider
    {
        const string filename = "University.xml";
        XmlDocument xmlDocument = new XmlDocument();
        List<DBOAddress> dboAddresses = new List<DBOAddress>();
        public XMLDBProvider()
        {

        }


        public List<Faculty> GetFaculties()//metod of providing the list of faculties
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;//getting a root element

            List<Faculty> faculties = new List<Faculty>();//list of faculties to return
            List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
            foreach (XmlNode node in root)//loop for search a faculty-elements
            {
                if (node.Name == "faculties")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboFaculties.Add(new DBOFaculty(childnode["name"].InnerText, Convert.ToInt32(childnode["idUniversity"].InnerText), Convert.ToInt32(childnode["idFaculty"].InnerText), Convert.ToInt32(childnode["idAddress"].InnerText)));
                    }
                }
                if (node.Name == "addresses")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboAddresses.Add(new DBOAddress(Convert.ToInt32(childnode["idAddress"].InnerText), childnode["street"].InnerText, childnode["city"].InnerText, childnode["building"].InnerText));
                    }
                }
            }
            foreach (DBOFaculty faculty in dboFaculties)
            {
                foreach (DBOAddress address in dboAddresses)
                {
                    if (faculty.idAddress == address.idAddress)
                    {
                        faculties.Add(new Faculty(faculty.name, new Adress(address.street, address.city, address.building)));
                    }
                }
            }
            return faculties;
        }

        public List<Service> GetServices()//metod of providing the list of faculties
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;//getting a root element

            List<Service> services = new List<Service>();//list of faculties to return
            List<DBOService> dboServices = new List<DBOService>();
            foreach (XmlNode node in root)//loop for search a faculty-elements
            {
                if (node.Name == "services")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboServices.Add(new DBOService(childnode["name"].InnerText, Convert.ToInt32(childnode["idUniversity"].InnerText), Convert.ToInt32(childnode["idService"].InnerText), Convert.ToInt32(childnode["idAddress"].InnerText)));
                    }
                }
            }
            foreach (DBOService service in dboServices)
            {
                foreach (DBOAddress address in dboAddresses)
                {
                    if (service.idAddress == address.idAddress)
                    {
                        services.Add(new Service(service.name, new Adress(address.street, address.city, address.building)));
                    }
                }
            }
            return services;
        }

        public List<Institute> GetInstitutes()
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;

            List<Institute> institutes = new List<Institute>();
            List<DBOInstitute> dboInstitutes = new List<DBOInstitute>();
            foreach(XmlNode node in root)
            {
                if(node.Name == "institutes")
                {
                    foreach(XmlNode childnode in node.ChildNodes)
                    {
                        dboInstitutes.Add(new DBOInstitute(childnode["name"].InnerText, Convert.ToInt32(childnode["idUniversity"].InnerText), Convert.ToInt32(childnode["idInstitute"].InnerText), Convert.ToInt32(childnode["idAddress"].InnerText)));
                    }
                }
            }
            foreach (DBOInstitute institute in dboInstitutes)
            {
                foreach(DBOAddress address in dboAddresses)
                {
                    if(institute.idAddress == address.idAddress)
                    {
                        institutes.Add(new Institute(institute.name, new Adress(address.street, address.city, address.building)));
                    }
                }
            }
            return institutes;
        }

        public List<DBOFaculty> GetDBOFaculties()//metod of providing the list of faculties
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;
            List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
            foreach (XmlNode node in root)
            {
                if (node.Name == "faculties")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboFaculties.Add(new DBOFaculty(childnode["name"].InnerText, Convert.ToInt32(childnode["idUniversity"].InnerText), Convert.ToInt32(childnode["idFaculty"].InnerText), Convert.ToInt32(childnode["idAddress"].InnerText)));
                    }
                }
            }
            foreach (DBOFaculty db in dboFaculties)
            {
                Console.WriteLine(db.idFaculty);
                }
                return dboFaculties;
        }
        public List<DBOStudent> GetDBOStudents()//metod of providing the list of faculties
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;
            List<DBOStudent> dboStudents = new List<DBOStudent>();
            foreach (XmlNode node in root)
            {
                if (node.Name == "students")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboStudents.Add(new DBOStudent(childnode["firstname"].InnerText, childnode["lastname"].InnerText, Convert.ToInt32(childnode["age"].InnerText), Convert.ToInt32(childnode["idFaculty"].InnerText)));

                    }
                }
            }
            return dboStudents;
        }
        public List<DBODean> GetDBODeans()//metod of providing the list of faculties
        {
            xmlDocument.Load(filename);
            XmlElement root = xmlDocument.DocumentElement;
            List<DBODean> dboDeans = new List<DBODean>();
            foreach (XmlNode node in root)
            {
                if (node.Name == "deans")
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        dboDeans.Add(new DBODean(childnode["firstname"].InnerText, childnode["lastname"].InnerText, Convert.ToInt32(childnode["age"].InnerText), Convert.ToInt32(childnode["idFaculty"].InnerText)));

                    }
                }
            }
            foreach (DBODean db in dboDeans)
            {
                Console.WriteLine(db.idFaculty);
            }
            return dboDeans;
        }
    }
}





