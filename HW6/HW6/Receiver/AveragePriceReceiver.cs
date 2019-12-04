using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class AveragePriceReceiver
    {
        public void CalculateAveragePrice(List<ProductCar> cars)
        {
            int helper = 0;
            foreach(ProductCar car in cars)
            {
                helper += car.Price; 
            }
            double averagePrice = (double) helper / cars.Count;
            Program.Output(averagePrice);
        }
    }
}
