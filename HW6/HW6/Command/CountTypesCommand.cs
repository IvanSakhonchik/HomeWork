using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class CountTypesCommand:ICommand
    {
        CountTypesReceiver receiver;
        List<ProductCar> cars;
        public CountTypesCommand(CountTypesReceiver receiver, List<ProductCar> cars)
        {
            this.receiver = receiver;
            this.cars = cars;
        }

        public void Execute()
        {
            receiver.CalculateCountTypes(cars);
        }
    }
}
