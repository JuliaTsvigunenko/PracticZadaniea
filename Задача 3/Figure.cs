using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figure
    {
        private double perimeter;

        public double Perimeter { get; set; }
        

        public Figure(Point a, Point b, Point c)
        {
            Perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a);
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            Perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a);
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            Perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр равен: {Perimeter}");
        }

    }
}
