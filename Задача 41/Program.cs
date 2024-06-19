using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров Point с разными типами данных
            Point<int> intPoint = new Point<int>(3, 5);
            Point<uint> uintPoint = new Point<uint>(10, 20);
            Point<double> doublePoint = new Point<double>(2.5, 4.8);

            // Вывод координат точек
            Console.WriteLine("Целочисленная точка:");
            intPoint.Print();

            Console.WriteLine("\nЦелочисленная точка без знака:");
            uintPoint.Print();

            Console.WriteLine("\nДробная точка:");
            doublePoint.Print();

            Console.ReadLine();
        }
    }
}
