using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Motorcade
    {
        List<string> vehicles = new List<string>();

        List<Garage> garages = new List<Garage>();

        AutoChief chief ;

        public Motorcade()
        {
        }

        public bool AddVehicle(string newVehicle)
        {
            if (vehicles.Count > 9)
            {
                Console.Write("No more space in list of vehicle for:  ");
                Console.WriteLine(newVehicle);
                Console.WriteLine("\n");
                return false;
            }

            foreach (string veh in vehicles)
            {
                if (veh == newVehicle)
                {
                    Console.Write(newVehicle);
                    Console.WriteLine(" already exists among vehicles.");
                    return false;
                }
            }

            vehicles.Add(newVehicle);
            return true;
        }

        public bool AddGarage(Garage newGarage)
        {
            if (garages.Count > 9)
            {
                Console.Write("No more space in list of garages for:  ");
                Console.WriteLine(newGarage);
                Console.WriteLine("\n");
                return false;
            }

            foreach (Garage gar in garages)
            {
                if (gar.Equals(newGarage))
                {
                    Console.Write(newGarage);
                    Console.WriteLine(" already exists among garages.");
                    return false;
                }
            }

            garages.Add(newGarage);
            return true;
        }

        public bool AddAutoChief(AutoChief chief)
        {
            this.chief = chief;
            return true;
        }
        public void Output()
        {
            Console.WriteLine("                 RESULT FOR MOTORCADE");
            Console.WriteLine($"Motorcade under the direction of Chief: {chief}");
            Console.WriteLine("Garages:");
            foreach (Garage gar in garages)
            {
                Console.WriteLine(gar);
            }
            Console.WriteLine("Vehicles:");
            foreach (string veh in vehicles)
            {
                Console.WriteLine(veh);
            }
        }
    }
}
