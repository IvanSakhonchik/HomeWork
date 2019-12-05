using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class AveragePriceCommand:ICommand
    {
        AveragePriceReceiver receiver;
        List<ProductCar> cars;
        
        public AveragePriceCommand(AveragePriceReceiver receiver, List<ProductCar> cars)
        {
            this.receiver = receiver;
            this.cars = cars;
        }

        public void Execute()
        {
            receiver.CalculateAveragePrice(cars);
        }
    }
}
