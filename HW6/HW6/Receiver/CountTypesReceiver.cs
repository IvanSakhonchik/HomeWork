using System;
using System.Collections.Generic;
using System.Linq;

namespace HW6
{
    class CountTypesReceiver
    {
        public void CalculateCountTypes(List<ProductCar> cars)
        {
            var sortCars = cars.OrderBy(c => c.Type).ToList();
            int countTypes = 1;
            for(int i = 0 ; i < sortCars.Count-1; i++)
            {
                if (sortCars[i].Type != sortCars[i+1].Type)
                {
                    countTypes++;
                }
            }

            Program.Output(countTypes);
        }
    }
}
