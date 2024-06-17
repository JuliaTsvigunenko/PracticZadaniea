using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список устройств с возможностью включения и выключения
            List<ISwitchable> devices = new List<ISwitchable>

            {
            new TVSet(),
            new PersonalComputer()
            };

            // Включаем и выключаем устройства
            foreach (var device in devices)
            {
                device.TurnOn();
                device.TurnOff();
            }

            Console.ReadKey();
        }
    }
}
