using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
        public Point() { }
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public static Point Input()
        {
            Console.Write("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название точки:");
            string name = Console.ReadLine();
            return new Point(x, y, name);
        }
    }
}
