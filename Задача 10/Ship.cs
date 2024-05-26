using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад._10
{
    class Ship : Vehicle
    {


        private int passengers1;
        private int homePort;

        public int Passengers1 { get { return passengers1; } set { passengers1 = value; } }
        public int HomePort { get { return homePort; } set { homePort = value; } }
        public Ship(double price, double speed, int years, int passengers1, int homePort) : base(price, speed, years)
        {
            this.Passengers1 = passengers1;
            this.HomePort = homePort;
        }
        public override void Transport()
        {
            Console.WriteLine($"Цена транспорта: {Price}\nСкорость: {Speed}\nГод выпуска: {Years}\nКоличество пассажиров: {Passengers1}\nПорт приписки: {HomePort}");
        }
        static public Ship Show()
        {
            Console.WriteLine("Введите цену корабля: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость корабля: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите год выпуска корабля: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество пассажиров: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порт приписки: ");
            int homePort = Convert.ToInt32(Console.ReadLine());
            return new Ship(price, speed, years, quantity, homePort);
        }


    }
}
