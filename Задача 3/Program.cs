using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure f = new Figure(Point.Input(), Point.Input(), Point.Input());
            f.CalculatePerimeter();

        }
    }
}
