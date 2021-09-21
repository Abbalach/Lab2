using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(4,3, "1"), new Point(1, 2, "2"), new Point(12, 7, "3"), new Point(10, 6, "4"), new Point(5, 5, "4"));
            figure.GetName();
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
