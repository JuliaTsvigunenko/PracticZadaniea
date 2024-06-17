using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем объект класса MyClass
            MyClass myClass = new MyClass();

            // Вызываем и выводим результаты методов
            Console.WriteLine("Число PI: " + myClass.GetPI());
            Console.WriteLine("Число типа int: " + myClass.GetInteger());
            double number = 16.0;
            Console.WriteLine($"Квадрат числа {number}: " + myClass.Square(number));
            Console.WriteLine($"Квадратный корень из числа {number}: " + myClass.SquareRoot(number));

            Console.ReadKey();
        }
    }
}
