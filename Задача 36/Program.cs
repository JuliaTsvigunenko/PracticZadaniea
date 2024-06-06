using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Human> humans = new List<Human>
            {
            new Russian("Александр"),
            new Ukrainian("Лев"),
            new American("Amelia")
            };

            
            foreach (var human in humans)
            {
                human.Privet();
            }

            Console.ReadKey();
        }
    }
}
