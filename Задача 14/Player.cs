using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Player : IPlayable, IRecodable
    {

        // Реализация методов интерфейса IPlayable
        public void Play()
        {
            Console.WriteLine("Проигрывание началось.");
        }

        public void Pause()
        {
            Console.WriteLine("Проигрывание приостановлено.");
        }

        public void Stop()
        {
            Console.WriteLine("Проигрывание остановлено.");
        }

        // Реализация методов интерфейса IRecodable
        public void Record()
        {
            Console.WriteLine("Запись началась.");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена.");
        }

    }
}
