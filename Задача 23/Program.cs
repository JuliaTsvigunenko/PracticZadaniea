using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Каким цветом вывести текст? ");
            foreach(Color.Colors c in Enum.GetValues(typeof (Color.Colors)))
            {
                Console.WriteLine($"{(int)c} - {c}");
            }
            Console.WriteLine("Введите цифру цвета: ");
            int color = Convert.ToInt32(Console.ReadLine());
            Color.Print(stroka, color);

            Console.ReadLine();


        }
    }
}
