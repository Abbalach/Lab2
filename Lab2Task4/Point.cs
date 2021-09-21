using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task4
{
    class Point
    {
        public int Coordinate_X { get; }
        public int Coordinate_Y { get; }
        public string Name { get; }
        public Point(int x, int y, string name)
        {
            Coordinate_X = x;
            Coordinate_Y = y;
            Name = name;
        }
    }
}
