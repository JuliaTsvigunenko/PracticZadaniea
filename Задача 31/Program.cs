using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Введите первое число:");
            double num1 = ReadDoubleFromConsole();

            Console.WriteLine("Введите второе число:");
            double num2 = ReadDoubleFromConsole();

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");

            int choice = ReadIntFromConsole();

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = calc.Add(num1, num2);
                    break;
                case 2:
                    result = calc.Sub(num1, num2);
                    break;
                case 3:
                    result = calc.Mul(num1, num2);
                    break;
                case 4:
                    result = calc.Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор операции.");
                    return;
            }

            Console.WriteLine($"Результат операции: {result}");
        }

        // Метод для чтения вещественного числа из консоли с обработкой исключений
        static double ReadDoubleFromConsole()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите корректное число:");
            }
            return number;
        }

        // Метод для чтения целого числа из консоли с обработкой исключений
        static int ReadIntFromConsole()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите целое число:");
            }
            return number;

        }

        
    }
    
    
}
