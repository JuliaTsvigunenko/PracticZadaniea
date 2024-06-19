using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя ввод строки.
            Console.Write("Введите строку: ");
            // Считываем введенную пользователем строку и сохраняем ее в переменную `value`.
            string value = Console.ReadLine();
            // Создаем экземпляр базового класса Printer, который будет выводить текст без изменения цвета.
            Printer defaultPrinter = new Printer();
            // Создаем экземпляр производного класса RedPrinter, который будет выводить текст красным цветом.
            Printer redPrinter = new RedPrinter();
            // Вызываем метод Print базового класса Printer, который выводит текст без изменения цвета.
            defaultPrinter.Print(value);
            // Вызываем метод Print производного класса RedPrinter, который выводит текст красным цветом.
            redPrinter.Print(value);
            // Ожидаем, пока пользователь нажмет Enter, чтобы завершить выполнение программы.
            Console.ReadLine();

        }
    }
}
