using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Circle
    {
        private double _radius { get; }

        public double Area
        {
            get
            {
                return 3.14 * Math.Pow(this._radius, 2);
            }
        }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {this._radius}\n" +
                $"Area: {Area}");
        }
    }
}
