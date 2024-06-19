using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Calculator
    {
        // Метод для сложения двух чисел
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Метод для вычитания двух чисел
        public double Sub(double a, double b)
        {
            return a - b;
        }

        // Метод для умножения двух чисел
        public double Mul(double a, double b)
        {
            return a * b;
        }

        // Метод для деления двух чисел с проверкой деления на ноль
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
                return double.NaN; // возвращаем NaN (Not-a-Number) в случае ошибки
            }
            return a / b;
        }

    }
}
