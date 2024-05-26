using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад._10
{
    class Automobile : Vehicle
    {

        public Automobile(double price, double speed, int years) : base(price, speed, years) { }

        public override void Transport()
        {
            Console.WriteLine($"Цена транспорта: {Price}\nСкорость: {Speed}\nГод выпуска: {Years}");
        }

        public static Automobile Show()
        {
            Console.WriteLine("Введите цену машины: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость машины: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите год выпуска машины: ");
            int years = Convert.ToInt32(Console.ReadLine());
            return new Automobile(price, speed, years);
        }


    }
}
