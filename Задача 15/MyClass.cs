using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class MyClass : InterfaceC
    {

        // Реализация метода из InterfaceA
        public void ShowInterfaceA()
        {
            Console.WriteLine("Метод ShowInterfaceA из InterfaceA");
        }

        // Реализация метода из InterfaceB
        public void ShowInterfaceB()
        {
            Console.WriteLine("Метод ShowInterfaceB из InterfaceB");
        }
    }
}
