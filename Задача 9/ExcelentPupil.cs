using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    // Производный класс ученика, который учится отлично
    class ExcelentPupil : Pupil
    {

        public ExcelentPupil(string surname) : base(surname)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{Surname} учится отлично!");
        }

        public override void Read()
        {
            Console.WriteLine($"{Surname} читает очень быстро!");
        }

        public override void Write()
        {
            Console.WriteLine($"{Surname} пишет без ошибок!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Surname} отдыхает, играя в шахматы!");
        }

    }
}
