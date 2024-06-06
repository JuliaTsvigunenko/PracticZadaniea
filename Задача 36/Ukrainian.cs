using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Ukrainian : Human
    {

        public Ukrainian(string name) : base(name)
        {
        }

        public override void Privet()
        {
            Console.WriteLine($"Привiт, {Name}!");
        }

    }
}
