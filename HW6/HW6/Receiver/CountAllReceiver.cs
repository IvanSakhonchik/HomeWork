using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class CountAllReceiver
    {
        public void CalculateCountAll(List<ProductCar> cars)
        {
            int count = 0;
            foreach(ProductCar car in cars)
            {
                count += car.Amount;
            }
            Program.Output(count);
        }
    }
}
