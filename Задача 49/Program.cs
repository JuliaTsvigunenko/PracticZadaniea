using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_49
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создание нескольких точек
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-1, 5);
            Point point3 = new Point(-3, -4);

            // Вывод координат каждой точки
            point1.PrintCoordinates();
            point2.PrintCoordinates();
            point3.PrintCoordinates();

            // Вывод количества точек в каждой четверти и общего количества точек
            Point.PrintPointCounts();

            Console.ReadLine();
        }
    }

    //Объяснение:
    //Класс Point: Описывает точку на плоскости с координатами x и y.
    //Статические поля: countQ1, countQ2, countQ3, countQ4, totalCount используются для подсчета точек в каждой четверти и общего количества точек.
    //Конструктор Point(int x, int y): Инициализирует координаты точки и обновляет счетчики точек в соответствующих четвертях.
    //Метод PrintCoordinates(): Выводит на экран координаты текущей точки.
    //Статический метод PrintPointCounts(): Выводит на экран количество точек в каждой четверти и общее количество точек.
    //Программа в методе Main() создает несколько точек, выводит их координаты и затем выводит общее количество точек и количество точек в каждой четверти с помощью статического метода PrintPointCounts() класса Point.



}
