using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class AveragePriceTypeCommand:ICommand
    {
        AveragePriceTypeReceiver receiver;
        List<ProductCar> cars;
        string type;

        public AveragePriceTypeCommand(AveragePriceTypeReceiver receiver, List<ProductCar> cars, string type)
        {
            this.receiver = receiver;
            this.cars = cars;
            this.type = type;
        }

        public void Execute()
        {
            receiver.CalculateAveragePriceType(cars, type);
        }
    }
}
