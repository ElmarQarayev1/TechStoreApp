using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
           // Console.WriteLine("Product created");
        }
        public string Name;
        public double Price;
    }
}