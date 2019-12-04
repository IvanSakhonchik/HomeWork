using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class ProductCar
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public ProductCar(string type, string model, int amount, int price)
        {
            Type = type;
            Model = model;
            Amount = amount;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return Type == (obj as ProductCar).Type;
        }
    }
}
