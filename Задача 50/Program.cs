using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_50
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ввод данных с клавиатуры
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            // Создание объекта с использованием конструктора с параметрами
            DateClass date = new DateClass(year, month, day);

            // Вывод информации о дате
            date.ShowDate();

            // Вычисление и вывод даты предыдущего дня
            DateTime previousDay = date.PreviousDay();
            Console.WriteLine($"Предыдущий день: {previousDay.ToShortDateString()}");

            // Вычисление и вывод даты следующего дня
            DateTime nextDay = date.NextDay();
            Console.WriteLine($"Следующий день: {nextDay.ToShortDateString()}");

            Console.ReadKey();

        }
    }
}
