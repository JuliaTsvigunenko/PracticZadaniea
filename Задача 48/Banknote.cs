using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_48
{
    class Banknote
    {
        public string Name { get; private set; }       // Название купюры
        public int Denomination { get; private set; }  // Номинал купюры
        public int Count { get; private set; }         // Количество купюр

        // Конструктор по умолчанию инициализирует купюру неизвестными значениями
        public Banknote()
        {
            Name = "Неизвестно";
            Denomination = 0;
            Count = 0;
        }

        // Конструктор с параметрами для инициализации купюры заданными значениями
        public Banknote(string name, int denomination, int count)
        {
            Name = name;
            Denomination = denomination;
            Count = count;
        }

        // Метод для вывода информации о купюре
        public void Display()
        {
            Console.WriteLine($"Название: {Name}, Номинал: {Denomination}, Количество: {Count}");
        }

        // Метод для изменения количества купюр на указанное число
        public void ChangeCount(int delta)
        {
            Count += delta;
        }

        // Метод для проверки, достаточно ли средств для оплаты указанной суммы
        public bool CanPay(int amount)
        {
            return amount <= Count * Denomination;
        }
    }
}
