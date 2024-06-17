using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    // Интерфейс A
    interface InterfaceA
    {
        // Метод для интерфейса A
        void ShowInterfaceA();
    }

    // Интерфейс B
    interface InterfaceB
    {
        // Метод для интерфейса B
        void ShowInterfaceB();
    }

    // Интерфейс C, реализующий множественное наследование от InterfaceA и InterfaceB
    interface InterfaceC : InterfaceA, InterfaceB
    {
        // Дополнительные методы, если необходимо, можно добавить здесь
    }
}
