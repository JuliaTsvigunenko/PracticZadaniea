using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Russian : Human
    {

        public Russian(string name) : base(name) 
        {
        }

        public override void Privet()
        {
            Console.WriteLine($"Привет, {Name}!");
        }

    }
}
