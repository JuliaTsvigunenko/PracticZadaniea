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
            // Создание массива объектов класса Product (Товар)
            Product[] products = new Product[]
            {
            new Product("Молоко", "Простоквашино", 50.0m, 10, 100),
            new Product("Хлеб", "Бородинский", 30.0m, 7, 150),
            new Product("Мясо", "Мясновъ", 400.0m, 5, 50),
            new Product("Яйца", "Куриные радости", 70.0m, 15, 200),
            new Product("Шоколад", "Аленка", 80.0m, 30, 80),
            new Product("Сок", "Добрый", 90.0m, 20, 120)
            };

            // Примеры использования методов для вывода списков товаров по различным критериям
            Console.WriteLine("Список товаров по заданному наименованию (Хлеб):");
            PrintProductsByName(products, "Хлеб");
            Console.WriteLine();

            Console.WriteLine("Список товаров по заданному наименованию и цене не выше 500 рублей (Мясо):");
            PrintProductsByNameAndPrice(products, "Мясо", 500.0m);
            Console.WriteLine();

            Console.WriteLine("Список товаров с сроком хранения больше 10 дней:");
            PrintProductsByShelfLife(products, 10);
            Console.WriteLine();
        }

        // Метод для вывода списка товаров по заданному наименованию
        static void PrintProductsByName(Product[] products, string name)
        {
            // Используем LINQ для фильтрации товаров по заданному наименованию
            var filteredProducts = products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            // Выводим отфильтрованные товары
            PrintProducts(filteredProducts);
        }

        // Метод для вывода списка товаров по заданному наименованию и не превышающей цене
        static void PrintProductsByNameAndPrice(Product[] products, string name, decimal maxPrice)
        {
            // Используем LINQ для фильтрации товаров по заданному наименованию и цене не выше указанной
            var filteredProducts = products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && p.Price <= maxPrice);

            // Выводим отфильтрованные товары
            PrintProducts(filteredProducts);
        }

        // Метод для вывода списка товаров с заданным сроком хранения
        static void PrintProductsByShelfLife(Product[] products, int minShelfLife)
        {
            // Используем LINQ для фильтрации товаров по заданному сроку хранения
            var filteredProducts = products.Where(p => p.ShelfLife > minShelfLife);

            // Выводим отфильтрованные товары
            PrintProducts(filteredProducts);
        }

        // Метод для вывода списка товаров
        static void PrintProducts(IEnumerable<Product> products)
        {
            // Проверка наличия товаров для вывода
            if (products.Any())
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product); // Выводим информацию о товаре, используя переопределенный ToString()
                }
            }
            else
            {
                Console.WriteLine("Товары не найдены.");
            }
            Console.ReadKey();
        }
        
    }
    
}
