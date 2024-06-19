using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Computer
    {
        private string model;
        private int ram; // в ГБайт
        private int hdd; // в ГБайт

        // Статическое поле для хранения общей стоимости всех моделей
        private static double totalCost = 0;

        // Свойство для доступа к модели компьютера
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Свойство для доступа к объему оперативной памяти
        public int RAM
        {
            get { return ram; }
            set
            {
                // Проверка на соответствие ограничениям (от 2 до 32 ГБайт)
                if (value >= 2 && value <= 32)
                    ram = value;
                else
                    throw new ArgumentOutOfRangeException("RAM должен быть от 2 до 32 ГБайт");
            }
        }

        // Свойство для доступа к объему жесткого диска
        public int HDD
        {
            get { return hdd; }
            set
            {
                // Проверка на соответствие ограничениям (от 200 до 2000 ГБайт)
                if (value >= 200 && value <= 2000)
                    hdd = value;
                else
                    throw new ArgumentOutOfRangeException("HDD должен быть от 200 до 2000 ГБайт");
            }
        }

        // Конструктор класса с параметрами
        public Computer(string model, int ram, int hdd)
        {
            Model = model;
            RAM = ram;
            HDD = hdd;

            // Вычисляем стоимость модели
            double modelCost = CalculateCost();
            // Добавляем стоимость модели к общей стоимости всех моделей
            totalCost += modelCost;
        }

        // Метод для вычисления стоимости модели на основе объема ОЗУ и HDD
        private double CalculateCost()
        {
            // Примерный алгоритм для вычисления стоимости (можно заменить на более реалистичный)
            double ramCost = ram * 10; // Предположим, что каждый ГБ стоит 10$
            double hddCost = hdd * 0.5; // Предположим, что каждый ГБ жесткого диска стоит 0.5$

            return ramCost + hddCost;
        }

        // Статический метод для вывода общей стоимости всех моделей
        public static void PrintTotalCost()
        {
            Console.WriteLine($"Общая стоимость всех моделей: {totalCost:C}");
        }
    }
}
