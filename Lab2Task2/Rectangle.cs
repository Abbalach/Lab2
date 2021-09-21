using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task2
{
    class Rectangle
    {
        private double Side1 { set; get; }
        private double Side2 { set; get; }
        public double Area { get; }
        public double Perimeter { get; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
            Perimeter = 2 * (Side1 + Side2);
            Area = Side1 * Side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (Side1 + Side2);
        }
        public double AreaCalculator()
        {
            return Side1 * Side2;
        }
    }
}
