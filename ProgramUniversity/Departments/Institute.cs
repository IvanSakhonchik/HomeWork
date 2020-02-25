using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramUniversity
{
    class Institute : Department
    {
        List<Employe> employes = new List<Employe>();
        Manager manager;

        public Institute(string name, Adress adress) : base(name, adress)
        {
        }

        public bool AddEmploye(Employe newEmploye)
        {
            if (employes.Count > 9)
            {
                Console.Write("No more space in list of employes for:  ");
                Console.WriteLine(newEmploye);
                Console.WriteLine("\n");
                return false;
            }

            foreach (Employe emp in employes)
            {
                if (emp.Equals(newEmploye))
                {
                    Console.Write(newEmploye);
                    Console.WriteLine(" already exists among employes.");
                    return false;
                }
            }

            employes.Add(newEmploye);
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $"under the direction of Manager: {manager}";

        }
        public bool AddManager(Manager manager)
        {
            this.manager = manager;
            return true;
        }
        public void Output()
        {
            Console.WriteLine("          RESULT FOR INSTITUTE ");
            foreach (Employe emp in employes)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n\n");
        }
    }
}
