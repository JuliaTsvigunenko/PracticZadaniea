using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем список товаров 
            List<Tovar> tovari = new List<Tovar>
            {
            new Obuv("Лоферы", 1500, 1, 38),
            new Odejda("Юбка", 500, 3, "M", "Белая"),
            new Posuda("Чашка", 100, 6, 0.3)
            };

            // Проходим по каждому товару в списке и выводим его информацию
            foreach (var tovar in tovari)
            {
                tovar.Print();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
