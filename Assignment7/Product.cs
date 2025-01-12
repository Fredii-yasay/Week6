using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Product
    {
        private string Name { get; set; }
        public double _Price { get; private set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this._Price = price;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product Details:\n" +
                $"Product: {this.Name}\n" +
                $"Price: {this._Price}");
        }
    }
}
