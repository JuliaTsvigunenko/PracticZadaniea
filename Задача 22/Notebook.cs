using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    struct Notebook
    {
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public decimal Price { get; private set; }

        // Конструктор для инициализации полей
        public Notebook(string model, string manufacturer, decimal price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        // Метод для вывода содержимого полей на экран
        public void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price:C}");
        }

    }
}
