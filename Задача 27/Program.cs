using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Шаг 1: Создание обобщенного списка из названий цветов
            List<string> colorsList = new List<string>();

            // Шаг 2: Добавление элементов строчными буквами
            colorsList.Add("red");
            colorsList.Add("green");
            colorsList.Add("blue");

            // Шаг 3: Вывод содержимого коллекции на экран
            Console.WriteLine("Содержимое коллекции после добавления строчных букв:");
            PrintListContents(colorsList);

            // Шаг 4: Преобразование всех букв элементов в прописные
            for (int i = 0; i < colorsList.Count; i++)
            {
                colorsList[i] = colorsList[i].ToUpper();
            }

            // Шаг 5: Вывод содержимого коллекции на экран после преобразования
            Console.WriteLine("\nСодержимое коллекции после преобразования в прописные буквы:");
            PrintListContents(colorsList);

            // Шаг 6: Определение текущего количества элементов коллекции
            int count = colorsList.Count;
            Console.WriteLine($"\nТекущее количество элементов в коллекции: {count}");

            // Шаг 7: Добавление нового элемента в конец списка
            colorsList.Add("YELLOW");

            // Шаг 8: Вывод содержимого коллекции на экран после добавления в конец
            Console.WriteLine("\nСодержимое коллекции после добавления элемента в конец:");
            PrintListContents(colorsList);

            // Шаг 9: Добавление нового элемента в начало списка
            colorsList.Insert(0, "ORANGE");

            // Шаг 10: Вывод содержимого коллекции на экран после добавления в начало
            Console.WriteLine("\nСодержимое коллекции после добавления элемента в начало:");
            PrintListContents(colorsList);

            // Шаг 11: Удаление третьего элемента коллекции (индекс 2)
            colorsList.RemoveAt(2);

            // Шаг 12: Вывод содержимого коллекции на экран после удаления третьего элемента
            Console.WriteLine("\nСодержимое коллекции после удаления третьего элемента:");
            PrintListContents(colorsList);

            // Шаг 13: Расположение элементов в обратном порядке
            colorsList.Reverse();

            // Шаг 14: Вывод содержимого коллекции на экран после обратного расположения
            Console.WriteLine("\nСодержимое коллекции после обратного расположения элементов:");
            PrintListContents(colorsList);

            Console.ReadLine();

        }

        // Метод для вывода содержимого списка на экран
        static void PrintListContents(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
