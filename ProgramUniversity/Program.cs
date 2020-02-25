using System;
using System.Xml;

namespace ProgramUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IDBProvider provider = new XMLDBProvider();//initialization of Data Baze Provider

            UniversityCreator creator = new UniversityCreator();//initialization of University Creator

            University university = creator.GetUniversity(provider);



            

        }
    }
}
