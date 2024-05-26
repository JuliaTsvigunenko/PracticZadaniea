using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад._10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                Console.WriteLine("Введите тип транспорта (Машина, Самолет, Корабль): ");
                string name = Console.ReadLine();
                switch (name.ToLower())
                {
                    case "машина":
                        vehicles.Add(Automobile.Show());
                        break;
                    case "самолет":
                        vehicles.Add(Plane.Show());
                        break;
                    case "корабль":
                        vehicles.Add(Ship.Show());
                        break;
                    default:
                        Console.WriteLine("Тип транспорта введен некорректно");
                        break;
                }
                Console.WriteLine("Хотите добавить еще транспорт? (да/нет)");
                string response = Console.ReadLine();
                if (response.ToLower() != "да")
                    break;
            }



        }
    }
}
