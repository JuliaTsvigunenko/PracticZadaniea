using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar tovar = new Tovar("Яблоки", 17, 6);
            Tovar tovar1 = new Tovar("Груша", 19, 7);
            Console.WriteLine($"Стоимость заказного товара: {tovar.Sum()}");
            Console.WriteLine($"Стоимость заказного товара: {tovar1.Sum()}");
            Console.WriteLine($"Стоимость всего заказа: {tovar.Sum() + tovar1.Sum()}");
            Console.ReadKey();
        }
    }
}
