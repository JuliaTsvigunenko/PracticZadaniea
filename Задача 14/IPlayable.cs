using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    // Интерфейс для проигрывания
    interface IPlayable
    {
        // Метод для начала проигрывания
        void Play();
        // Метод для приостановки проигрывания
        void Pause();
        // Метод для остановки проигрывания
        void Stop();

    }
}
