using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_42
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования класса Triangle с разными типами данных
            Triangle<int, int, int> intTriangle = new Triangle<int, int, int>(3, 4, 5);
            intTriangle.PrintInfo();
            Console.WriteLine($"Площадь треугольника: {intTriangle.CalculateArea()}");

            Triangle<uint, uint, uint> uintTriangle = new Triangle<uint, uint, uint>(6, 8, 10);
            uintTriangle.PrintInfo();
            Console.WriteLine($"Площадь треугольника: {uintTriangle.CalculateArea()}");

            Triangle<double, double, double> doubleTriangle = new Triangle<double, double, double>(2.5, 3.5, 4.5);
            doubleTriangle.PrintInfo();
            Console.WriteLine($"Площадь треугольника: {doubleTriangle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}
