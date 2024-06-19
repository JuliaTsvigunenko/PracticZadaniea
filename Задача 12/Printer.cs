using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Printer
    {
        // Определение метода Print в базовом классе Printer.
        public virtual void Print(string value)
        {
            // Метод выводит переданное значение (строку) на экран.
            // Используется метод Console.WriteLine, который выводит строку и переходит на новую строку.
            Console.WriteLine(value);
        }
    }
}
