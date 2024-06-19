using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта структуры Notebook с использованием конструктора
            Notebook notebook1 = new Notebook("MacBook Air", "Apple", 999.99m);

            // Вывод информации о ноутбуке
            Console.WriteLine("Информация о ноутбуке:");
            notebook1.DisplayInfo();

            Console.ReadLine();
        }
    }
}
