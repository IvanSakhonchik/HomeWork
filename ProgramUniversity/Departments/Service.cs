using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramUniversity
{
    class Service : Department
    {
        Head head;

        List<Booker> bookers = new List<Booker>();

        public Service(string name, Adress adress) : base(name, adress)
        {
        }

        public bool AddBooker(Booker newBooker)
        {
            if (bookers.Count > 9)
            {
                Console.Write("No more space in listof bookers for:  ");
                Console.WriteLine(newBooker);
                Console.WriteLine("\n");
                return false;
            }

            foreach (Booker bk in bookers)
            {
                if (bk.Equals(newBooker))
                {
                    Console.Write(newBooker);
                    Console.WriteLine(" already exists among bookers.");
                    return false;
                }
            }

            bookers.Add(newBooker);
            return true;
        }

        public bool AddHead(Head head)
        {
            this.head = head;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $"under the direction of Head: {head}";

        }

        public void Output()
        {
            Console.WriteLine("          RESULT FOR SERVICE ");
            foreach (Booker bk in bookers)
            {
                Console.WriteLine(bk);
            }
            Console.WriteLine("\n\n");
        }
    }
}
