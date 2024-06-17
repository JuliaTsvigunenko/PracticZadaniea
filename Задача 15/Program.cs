using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем объект класса MyClass
            MyClass myClassOb = new MyClass();

            // Вызываем методы, чтобы вывести нужный текст в консоль
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();

            Console.ReadKey();

        }
    }
}
