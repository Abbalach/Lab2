using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task4
{
    class Figure
    {
        public Point[] points { get; }
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }
        public double LengthSize(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.Coordinate_X - point2.Coordinate_X, 2) + Math.Pow(point1.Coordinate_Y - point2.Coordinate_Y, 2));
        }
        public void PerimeterCalculator()
        {
            double Perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (i == points.Length -1)
                {
                    Perimeter += LengthSize(points[i], points[0]);
                }
                else
                {
                    Perimeter += LengthSize(points[i], points[i + 1]);
                }                
            }
            Console.WriteLine("Perimeter = " + Perimeter);
        }
        public void GetName()
        {
            string name = "";
            for (int i = 0; i < points.Length - 1; i++)
            {
                name += points[i].Name;
            }
            Console.WriteLine("Name = " + name);
        }
    }
}
