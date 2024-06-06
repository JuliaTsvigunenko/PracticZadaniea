using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class American : Human
    {

        public American(string name) : base(name)
        {
        }

        public override void Privet()
        {
            Console.WriteLine($"Hello, {Name}!");
        }


    }
}
