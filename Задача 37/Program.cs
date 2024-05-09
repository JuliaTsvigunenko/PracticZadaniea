using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Объявление делегата для вычисления площади треугольника
        delegate double Triangle(double a, double b, double c);

        static void Main(string[] args)
        {
            // Создание экземпляра делегата и присвоение ему метода TriangleArea
            Triangle del = new Triangle(TriangleArea);

            double a1 = 3.6, b1 = 2.5, c1 = 1.2;
            double area1 = del.Invoke(a1, b1, c1);
            Console.WriteLine($"Площадь треугольника со сторонами {a1}, {b1}, {c1} равна {area1}");

            double a2 = 2.6, b2 = 7.3, c2 = 5.2;
            double area2 = del.Invoke(a2, b2, c2);
            Console.WriteLine($"Площадь треугольника со сторонами {a2}, {b2}, {c2} равна {area1}");

            double a3 = 1.6, b3 = 5.5, c3 = 8.2;
            double area3 = del.Invoke(a3, b3, c3);
            Console.WriteLine($"Площадь треугольника со сторонами {a3}, {b3}, {c3} равна {area1}");
        }

        // Метод для вычисления площади треугольника по формуле Герона
        static double TriangleArea(double a, double b, double c)
        {
            // Полупериметр треугольника
            double p = (a + b + c) / 2.0;
            // Формула Герона для площади
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
