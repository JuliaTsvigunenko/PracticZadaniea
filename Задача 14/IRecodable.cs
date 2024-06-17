using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    // Интерфейс для записи
    interface IRecodable
    {
        // Метод для начала записи
        void Record();
        // Метод для приостановки записи
        void Pause();
        // Метод для остановки записи
        void Stop();

    }
}
