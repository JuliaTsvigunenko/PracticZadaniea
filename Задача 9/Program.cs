using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {


            Pupil pup = new ExcelentPupil("Арсений:");
            ClassRoom classRoom = new ClassRoom(pup);
            classRoom.ShowInfo(pup);
            Console.WriteLine();
            Pupil pup1 = new GoodPupil("Евгений:");
            ClassRoom classRoom1 = new ClassRoom(pup);
            classRoom.ShowInfo(pup);
            Console.WriteLine();
            Pupil pup2 = new BadPupil("Андрей:");
            ClassRoom classRoom2 = new ClassRoom(pup);
            classRoom.ShowInfo(pup);

            Console.ReadKey();


        }
    }
}
