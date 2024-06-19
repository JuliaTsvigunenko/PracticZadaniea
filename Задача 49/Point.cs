using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_49
{
    class Point
    {
        private int x;
        private int y;

        // Статические поля для подсчета точек в каждой координатной четверти
        private static int countQ1;
        private static int countQ2;
        private static int countQ3;
        private static int countQ4;
        private static int totalCount;

        // Конструктор с параметрами для инициализации координат точки
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            UpdateQuadrantCounts();
            totalCount++;
        }

        // Метод для вывода координат точки
        public void PrintCoordinates()
        {
            Console.WriteLine($"Точка с координатами ({x}, {y})");
        }

        // Статический метод для вывода количества точек в каждой координатной четверти и общего количества точек
        public static void PrintPointCounts()
        {
            Console.WriteLine("Количество точек:");
            Console.WriteLine($"1-я четверть: {countQ1}");
            Console.WriteLine($"2-я четверть: {countQ2}");
            Console.WriteLine($"3-я четверть: {countQ3}");
            Console.WriteLine($"4-я четверть: {countQ4}");
            Console.WriteLine($"Всего точек: {totalCount}");
        }

        // Приватный метод для обновления счетчиков точек в четвертях
        private void UpdateQuadrantCounts()
        {
            if (x > 0 && y > 0)
            {
                countQ1++;
            }
            else if (x < 0 && y > 0)
            {
                countQ2++;
            }
            else if (x < 0 && y < 0)
            {
                countQ3++;
            }
            else if (x > 0 && y < 0)
            {
                countQ4++;
            }
            // Если точка лежит на осях координат, не учитываем ее в четвертях
        }
    }
}
