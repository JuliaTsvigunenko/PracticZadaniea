using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_42
{

    // Обобщенный класс Triangle
    public class Triangle<T, P, R>
    {
        // Поля треугольника
        private T sideA;
        private P sideB;
        private R sideC;

        // Конструктор с параметрами для инициализации сторон треугольника
        public Triangle(T a, P b, R c)
        {
            // Проверка условия существования треугольника
            if ((dynamic)Convert.ToDouble(a) + Convert.ToDouble(b) > Convert.ToDouble(c) &&
                (dynamic)Convert.ToDouble(a) + Convert.ToDouble(c) > Convert.ToDouble(b) &&
                (dynamic)Convert.ToDouble(b) + Convert.ToDouble(c) > Convert.ToDouble(a))
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }
            else
            {
                Console.WriteLine("Треугольник с такими сторонами не существует");
            }
        }

        // Свойства для доступа к полям треугольника
        public T A { get => sideA; set => sideA = value; }
        public P B { get => sideB; set => sideB = value; }
        public R C { get => sideC; set => sideC = value; }

        // Метод для вывода информации о треугольнике
        public void PrintInfo()
        {
            Console.WriteLine($"Треугольник со сторонами: {sideA}, {sideB}, {sideC}");
        }

        // Метод для вычисления площади треугольника
        public double CalculateArea()
        {
            // Приведение к double для вычисления площади
            double a = Convert.ToDouble(sideA);
            double b = Convert.ToDouble(sideB);
            double c = Convert.ToDouble(sideC);

            // Полупериметр треугольника
            double s = (a + b + c) / 2;

            // Формула Герона для вычисления площади треугольника
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}

