using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    // Интерфейс для устройств, имеющих возможность включения и выключения
    interface ISwitchable
    {
        void TurnOn(); // Метод для включения
        void TurnOff(); // Метод для выключения

    }
}
