using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Posuda : Tovar
    {

        public int Quantity { get; set; }
        public double Weight { get; set; }
        private double totalCost;

        public Posuda(string name, double price, int quantity, double weight)
            : base(name, price)
        {
            Quantity = quantity;
            Weight = weight;
        }

        public override void CalculatorSum()
        {
            totalCost = Price * Quantity;
        }

        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price:C}\nКоличество: {Quantity}\nМасса: {Weight} кг");
            CalculatorSum();
            Console.WriteLine($"Общая стоимость: {totalCost}");
        }

    }
}
