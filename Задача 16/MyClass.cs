using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    // Класс MyClass, реализующий интерфейс IMathOperations
    class MyClass : IMathOperations
    {

        // Реализация метода, возвращающего число PI
        public double GetPI()
        {
            return Math.PI;
        }

        // Реализация метода, возвращающего число типа int
        public int GetInteger()
        {
            return 42; // Пример числа типа int
        }

        // Реализация метода, возвращающего x в квадрате
        public double Square(double x)
        {
            return x * x;
        }

        // Реализация метода, возвращающего корень квадратный из x
        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

    }
}
