using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class AveragePriceTypeReceiver
    {
        public void CalculateAveragePriceType(List<ProductCar> cars, string type)
        {
            int helper = 0;
            int count = 0; 
            foreach(ProductCar car in cars)
            {
                if(car.Type == type)
                {
                    helper += car.Price;
                    count++;
                }
            }

            double averagePrice = (double)helper / count;
            Program.Output(averagePrice);
        }
    }
}
