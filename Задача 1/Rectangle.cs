using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        /// <summary>
        /// поле Сторона 2
        /// </summary>
        private double side1;
        /// <summary>
        /// поле Сторона 2
        /// </summary>
        private double side2;

        /// <summary>
        /// Св-ва доступа к полям сторона 1 и сторона 2
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// метод для вывода информации о сторонах
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Сторона1: {Side1}\nСторона2: {Side2}");
        }

        /// <summary>
        /// Метод нахождения периметра прямоугольника
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator()
        {
            return (Side1 + Side2) * 2;
        }

        /// <summary>
        ///  Метод нахождения площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
            return Side1 * Side2;
        }

    }

}
