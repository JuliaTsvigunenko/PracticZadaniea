using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    abstract class Tovar
    {

        public string Name { get; set; }

        public double Price { get; set; }

        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }

        
        public abstract void CalculatorSum();

        public abstract void Print();


    }
}
