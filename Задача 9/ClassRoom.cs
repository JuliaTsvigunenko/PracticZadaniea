using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class ClassRoom
    {

        /// <summary>
        /// Перегрузка конструкторов, когда метод имеет несколько параметров
        /// </summary>
        public ClassRoom()
        {
        }

        public ClassRoom(Pupil exelent)
        {
        }

        public ClassRoom(Pupil exelent, Pupil bad)
        {
        }

        public ClassRoom(Pupil exelent, Pupil bad, Pupil good)
        {
        }

        public ClassRoom(Pupil exelent, Pupil bad, Pupil good, Pupil good1)
        {
        }

        public void ShowInfo(Pupil pup)
        {
            Console.WriteLine($"Ученик {pup.Surname}");
            pup.Study();
            pup.Read();
            pup.Write();
            pup.Relax();
        }

    }
}
