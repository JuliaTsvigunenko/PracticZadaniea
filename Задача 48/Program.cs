using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_48
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Banknote с использованием различных конструкторов
            Banknote banknote1 = new Banknote();
            Banknote banknote2 = new Banknote("Доллар", 100, 50);
            Banknote banknote3 = new Banknote("Евро", 50, 20);

            // Вывод информации о купюрах
            Console.WriteLine("Информация о купюрах:");
            banknote1.Display();
            banknote2.Display();
            banknote3.Display();

            // Изменение количества купюр и проверка возможности оплаты
            banknote1.ChangeCount(10);
            banknote2.ChangeCount(-5);

            Console.WriteLine("\nПосле изменений:");
            banknote1.Display();
            banknote2.Display();
            banknote3.Display();

            // Проверка достаточности средств для оплаты
            int amountToPay = 3000;
            Console.WriteLine($"\nДостаточно ли средств для оплаты {amountToPay}?");
            Console.WriteLine($"Доллар: {banknote2.CanPay(amountToPay)}");
            Console.WriteLine($"Евро: {banknote3.CanPay(amountToPay)}");

            Console.ReadLine();

            //Информация о купюрах:
            //Первая купюра инициализируется конструктором по умолчанию, поэтому её значения "Неизвестно", 0, 0.
            //Вторая купюра инициализируется конструктором с параметрами "Доллар", 100, 50.
            //Третья купюра инициализируется конструктором с параметрами "Евро", 50, 20.

            //После изменений:
            //У первой купюры увеличивается количество на 10.
            //У второй купюры уменьшается количество на 5.
            //Третья купюра остаётся без изменений.

            //Достаточно ли средств для оплаты 3000:
            //Для купюры с номиналом 100(Доллар) считается, что средств недостаточно(False).
            //Для купюры с номиналом 50(Евро) считается, что средств достаточно(True).


        }
    }
}
