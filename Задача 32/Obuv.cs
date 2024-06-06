using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Obuv : Tovar
    {

        public int Quantity { get; set; }
        public int Size { get; set; }
        /// <summary>
        /// общая стоимость
        /// </summary>
        private double totalCost;

        public Obuv(string name, double price, int quantity, int size) : base(name, price)
        {
            Quantity = quantity;
            Size = size;
        }

        public override void CalculatorSum()
        {
            totalCost = Price * Quantity;
        }

        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price:C}\nКоличество: {Quantity}\nРазмер: {Size}");
            CalculatorSum();
            Console.WriteLine($"Общая стоимость: {totalCost}");
        }

    }
}
