using System;
using System.Collections.Generic;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of slots:");
            int slots = int.Parse(Console.ReadLine());
            List<ProductCar> cars = AddCars(slots);

            Invoker invoker = new Invoker();

            while (true)
            {
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "count types":
                        CountTypesReceiver countTypesReceiver = new CountTypesReceiver();
                        invoker.SetCommand(new CountTypesCommand(countTypesReceiver, cars));
                        invoker.Run();
                        break;
                    case "count all":
                        CountAllReceiver countAllReceiver = new CountAllReceiver();
                        invoker.SetCommand(new CountAllCommand(countAllReceiver, cars));
                        invoker.Run();
                        break;
                    case "average price":
                        AveragePriceReceiver averagePriceReceiver = new AveragePriceReceiver();
                        invoker.SetCommand(new AveragePriceCommand(averagePriceReceiver, cars));
                        invoker.Run();
                        break;
                    case "exit":
                        ExitReceiver exitReceiver = new ExitReceiver();
                        invoker.SetCommand(new ExitCommand(exitReceiver));
                        invoker.Run();
                        break;

                }

                foreach (ProductCar car in cars)
                {
                    string helper = "average price " + car.Type;
                    if (command == helper)
                    {
                        AveragePriceTypeReceiver averagePriceTypeReceiver = new AveragePriceTypeReceiver();
                        invoker.SetCommand(new AveragePriceTypeCommand(averagePriceTypeReceiver, cars, car.Type));
                        invoker.Run();
                    }
                    break;
                }
            }
        }
        
        static List<ProductCar> AddCars(int count)
        {
            List<ProductCar> cars = new List<ProductCar>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Mark:");
                string type = Console.ReadLine();
                Console.WriteLine("Model:");
                string model = Console.ReadLine();
                Console.WriteLine("Amount:");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Price:");
                int price = int.Parse(Console.ReadLine());
                ProductCar car = new ProductCar(type, model, amount, price);
                if (car.Amount > 0 && car.Price > 0)
                {
                    cars.Add(car);
                }
            }
            return cars;

        }

        public static void Output(object obj)
        {
            Console.WriteLine(obj);
        }

    }
}
