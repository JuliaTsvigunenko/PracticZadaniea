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

            Rectangle rec = new Rectangle(4, 2);
            rec.ShowInfo();
            Console.WriteLine($"периметр прямоугольника {rec.PerimeterCalculator()}");
            Console.WriteLine($"Площадь прямоугольника { rec.AreaCalculator()}");
            rec.AreaCalculator();

        }
    }
}
