using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем объект класса Player
            Player player = new Player();

            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine();

            IRecodable recodablePlayer = player;

            recodablePlayer.Record();
            recodablePlayer.Pause();
            recodablePlayer.Stop();

            Console.ReadKey();
        }
    }
}
