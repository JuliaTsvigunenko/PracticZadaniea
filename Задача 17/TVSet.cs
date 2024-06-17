using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    // Класс Телевизор, реализующий интерфейс ISwitchable
    class TVSet : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен.");
        }

    }
}
