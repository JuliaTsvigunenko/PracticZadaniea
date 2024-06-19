using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment<int> segment = new Segment<int>(1, 2, 4, -5);
            segment.ShowInfo();  // Вывод информации о сегменте
            Console.WriteLine(segment.LengthOfTheSegment());  // Вывод длины сегмента
            Segment<long> segment1 = new Segment<long>(1, 2, 4, -5);
            segment1.ShowInfo();  // Вывод информации о сегменте
            Console.WriteLine(segment1.LengthOfTheSegment());  // Вывод длины сегмента
            Segment<double> segment2 = new Segment<double>(4.4, 5.5, -2.2, -3.5);
            segment2.ShowInfo();  // Вывод информации о сегменте
            Console.WriteLine(segment2.LengthOfTheSegment());  // Вывод длины сегмента
            Console.ReadLine();  // Ожидание ввода пользователя перед закрытием консоли
        }
    }
}
