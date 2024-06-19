using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_47
{

    class Zakaz
    {
        // Поля с автоматическими свойствами, предоставляющими доступ к закрытым данным
        public string Fam { get; set; }// Фамилия клиента
        public int Size { get; set; }// Количество мест в заказе
        public string Comfort { get; set; }// Комфортность заказа

        // Конструктор по умолчанию, инициализирует поля значениями по умолчанию
        public Zakaz()
        {
            Fam = "Неизвестно";
            Size = 0;
            Comfort = "Стандарт";
        }

        // Конструктор с одним параметром - фамилией, остальные поля инициализируются значениями по умолчанию
        public Zakaz(string fam)
        {
            Fam = fam;
            Size = 0;
            Comfort = "Стандарт";
        }

        // Конструктор с двумя параметрами - фамилией и количеством мест,
        // комфортность устанавливается в значение по умолчанию "Стандарт"
        public Zakaz(string fam, int size)
        {
            Fam = fam;
            Size = size;
            Comfort = "Стандарт";
        }

        // Полный конструктор с тремя параметрами - фамилией, количеством мест и комфортностью
        public Zakaz(string fam, int size, string comfort)
        {
            Fam = fam;
            Size = size;
            Comfort = comfort;
        }

        // Метод для вывода информации о заказе на экран
        public void Show()
        {
            Console.WriteLine($"Фамилия: {Fam}, Количество мест: {Size}, Комфорт: {Comfort}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список для хранения заказов
            List<Zakaz> zakazi = new List<Zakaz>();

            while (true)
            {
                // Просим пользователя ввести фамилию или 'Q' для завершения
                Console.WriteLine("Введите фамилию (или 'Q' для завершения): ");
                string fam = Console.ReadLine().Trim(); // Считываем и убираем лишние пробелы

                if (fam.ToUpper() == "Q")
                    break; // Если введен 'Q', выходим из цикла

                // Просим пользователя ввести количество мест
                Console.WriteLine("Введите количество мест: ");
                int size = int.Parse(Console.ReadLine()); // Считываем и преобразуем ввод в int

                // Просим пользователя ввести комфортность
                Console.WriteLine("Введите комфортность: ");
                string comfort = Console.ReadLine(); // Считываем комфортность

                // Создаем новый объект Zakaz с введенными данными и добавляем в список
                Zakaz zakaz = new Zakaz(fam, size, comfort);
                zakazi.Add(zakaz);
            }

            // Выводим все заказы на экран
            Console.WriteLine("\nВсе заказы:");
            foreach (var zakaz in zakazi)
            {
                zakaz.Show();
            }

        }
    }
}
