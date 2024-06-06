using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    // Абстрактный класс Человек
    abstract class Human
    {

        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        // Абстрактный метод для приветствия
        public abstract void Privet();
    }
}
