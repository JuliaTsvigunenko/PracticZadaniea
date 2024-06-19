using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_44
{
    // Объявляем делегат
    public delegate int IntSumDelegate(int m, int n);

    class Program
    {
        static void Main(string[] args)
        {
            // Применяем делегат 3 раза
            IntSumDelegate delegate1 = new IntSumDelegate(intSum);
            IntSumDelegate delegate2 = new IntSumDelegate(intSum);
            IntSumDelegate delegate3 = new IntSumDelegate(intSum);

            // Вызываем делегаты с разными аргументами
            int result1 = delegate1(1, 5);
            int result2 = delegate2(10, 15);
            int result3 = delegate3(-3, 3);

            // Выводим результаты
            Console.WriteLine($"Сумма чисел от 1 до 5: {result1}");
            Console.WriteLine($"Сумма чисел от 10 до 15: {result2}");
            Console.WriteLine($"Сумма чисел от -3 до 3: {result3}");

            Console.ReadLine();
        }

        // Статический метод для вычисления суммы чисел от m до n
        static int intSum(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }


    }
}
