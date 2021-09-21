using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону");
            var side1 = Console.ReadLine();
            Console.WriteLine("Введите вторую сторону");
            var side2 = Console.ReadLine();
            bool helper = true;
            Rectangle rectangle = null;
            try
            {
                rectangle = new Rectangle(Convert.ToDouble(side1), Convert.ToDouble(side2));
            }
            catch 
            {
                Console.WriteLine("Вы ввели параметры неправильно.");
                helper = false;
            }
            if (helper)
            {
                Console.WriteLine("Площадь прямоугольника - " + rectangle.AreaCalculator());
                Console.WriteLine("Периметр прямоугольника - " + rectangle.PerimeterCalculator());
            }

            Console.ReadKey();
        }
    }
}
