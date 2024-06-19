using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Tovar
    {
        private string name;
        private double price;
        private int kvo;
        public string Name { get { return name; } set { name = value; } }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 1 || value > 20)
                    Console.Write("Кол-во должно быть в диапазоне от 1 до 20");
                else
                    price = value;
            }
        }
        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value < 0 || value > 10)
                    Console.Write("Кол-во должно быть в диапазоне от 0 до 10");
                else
                    kvo = value;
            }
        }
        // public Tovar() { }
        public Tovar(string name, double price, int kvo)
        {
            this.Name = name;
            this.Price = price;
            this.Kvo = kvo;
        }
        public static Tovar Print()
        {
            Console.Write("Введите название товара: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену товара: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество товара: ");
            int kvo = Convert.ToInt32(Console.ReadLine());
            return new Tovar(name, price, kvo);
        }
        public double Sum()
        {
            return Price * Kvo;
        }
    }
}
