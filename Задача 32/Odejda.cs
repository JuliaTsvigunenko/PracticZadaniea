using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Odejda : Tovar
    {

        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        private double totalCost;


        public Odejda(string name, double price, int quantity, string size, string color)
        : base(name, price)
        {
            Quantity = quantity;
            Size = size;
            Color = color;
        }

        public override void CalculatorSum()
        {
            totalCost = Price * Quantity;
        }


        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price:C}\nКоличество: {Quantity}\nРазмер: {Size}\nЦвет: {Color}");
            CalculatorSum();
            Console.WriteLine($"Общая стоимость: {totalCost}");
        }


    }
}
