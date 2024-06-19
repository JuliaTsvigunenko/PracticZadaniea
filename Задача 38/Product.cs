using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Product
    {
        // Поля класса Product
        public string Name { get; private set; }       // Наименование товара
        public string Manufacturer { get; private set; } // Производитель товара
        public decimal Price { get; private set; }     // Цена товара
        public int ShelfLife { get; private set; }     // Срок хранения товара в днях
        public int Quantity { get; private set; }      // Количество товара

        // Конструктор класса Product для инициализации полей
        public Product(string name, string manufacturer, decimal price, int shelfLife, int quantity)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLife = shelfLife;
            Quantity = quantity;
        }

        // Переопределение метода ToString() для вывода информации о товаре в строковом формате
        public override string ToString()
        {
            return $"Название: {Name}, Производитель: {Manufacturer}, Цена: {Price}, Срок хранения: {ShelfLife} дней, Количество: {Quantity}";
        }
    }
}
