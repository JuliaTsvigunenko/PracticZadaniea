using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад._10
{
    class Plane : Vehicle
    {


        /// <summary>
        /// создание поля высоты 
        /// </summary>
        private int height;
        /// <summary>
        /// создание поля количество пассажиров
        /// </summary>
        private int passengers;

        public int Height { get { return height; } set { height = value; } }
        public int Passengers { get { return passengers; } set { passengers = value; } }
        public Plane(double price, double speed, int years, int height, int passengers) : base(price, speed, years)
        {
            this.Height = height;
            this.Passengers = passengers;
        }
        public override void Transport()
        {
            Console.WriteLine($"Цена транспорта: {Price}\nСкорость: {Speed}\nГод выпуска: {Years}\nВысота: {Height}\nКоличество пассажиров: {Passengers}");
        }
        static public Plane Show()
        {
            Console.WriteLine("Введите цену самолета: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость самолета: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите год выпуска самолета: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту самолета: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество пассажиров: ");
            int colvo = Convert.ToInt32(Console.ReadLine());
            return new Plane(price, speed, years, height, colvo);
        }


    }
}
