using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class CountAllCommand : ICommand
    {
        CountAllReceiver receiver;
        List<ProductCar> cars;

        public CountAllCommand(CountAllReceiver receiver, List<ProductCar> cars)
        {
            this.receiver = receiver;
            this.cars = cars;
        }

        public void Execute()
        {
            receiver.CalculateCountAll(cars);
        }
    }
}
