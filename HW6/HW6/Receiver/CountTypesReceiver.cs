using System;
using System.Collections.Generic;
namespace HW6
{
    class CountTypesReceiver
    {
        public void CalculateCountTypes(List<ProductCar> cars)
        {
            int helper = 0;
            for(int i = 0 ; i < cars.Count-1; i++)
                for (int j = i+1; j < cars.Count; j++)
                {
                    if(cars[i].Equals(cars[j]))
                    {
                        helper++;
                    }

                }

            Program.Output(cars.Count - helper);
        }
    }
}
