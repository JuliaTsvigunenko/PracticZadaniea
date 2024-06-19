using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tour = new Tour();
            tour.TourCalc();
            tour.TourCalc("Греция");
            tour.TourCalc("Италия", 10);
            Console.ReadKey();
        }
    }
}
