using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>(); // Создаем список объектов класса Computer

            // Создаем несколько объектов класса Computer с разными параметрами
            Computer comp1 = new Computer("Model1", 8, 500); // Создаем компьютер с моделью "Model1", 8 ГБ RAM и 500 ГБ HDD
            Computer comp2 = new Computer("Model2", 16, 1000); // Создаем компьютер с моделью "Model2", 16 ГБ RAM и 1000 ГБ HDD
            Computer comp3 = new Computer("Model3", 32, 1500); // Создаем компьютер с моделью "Model3", 32 ГБ RAM и 1500 ГБ HDD

            computers.Add(comp1); // Добавляем объект comp1 в список computers
            computers.Add(comp2); // Добавляем объект comp2 в список computers
            computers.Add(comp3); // Добавляем объект comp3 в список computers

            // Выводим общую стоимость всех моделей
            Computer.PrintTotalCost();
            Console.ReadLine();

        }
    }
}
