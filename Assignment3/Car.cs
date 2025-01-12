using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car
    {
        private string _make { get; }
        private string _model { get; } 
        private int _year { get; }

        public Car(string make, string model, int year)
        {
            this._make = make;
            this._model = model;
            this._year = year;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Car Details:\n" +
                $"Make: {this._make}\n" +
                $"Model: {this._model}\n" +
                $"Year: {this._year}\n");
        }
    }
}
