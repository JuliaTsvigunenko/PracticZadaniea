using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_41
{
    // Обобщенный класс Point
    public class Point<T>
    {
        // Внутренние поля координат точки
        private T x;
        private T y;

        // Конструктор с двумя параметрами для инициализации координат
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойства доступа к внутренним полям класса
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод для вывода значений внутренних полей класса
        public void Print()
        {
            Console.WriteLine($"Координаты точки: ({x}, {y})");
        }
    }
}
