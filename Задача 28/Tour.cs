using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Tour
    {
        private string name;
        private double price;
        private double kolvoDays;

        public string Name { get; set; }
        public double Price { get; set; }
        public double KolvoDays { get; set; }

        public Tour() { }
        public Tour(string name, double price, double kolvoDays)
        {
            this.Name = name;
            this.Price = price;
            this.KolvoDays = kolvoDays;
        }
        public void TourCalc()
        {
            Console.WriteLine("Минское море, бесплатно");
        }
        public void TourCalc(string name)
        {
            kolvoDays = 1;
            price = 50;
            Console.WriteLine($"{name} - {kolvoDays} день {price} руб.");
        }
        public void TourCalc(string name, double kolvoDays)
        {
            Console.WriteLine($"{name}\tКоличество дней: {kolvoDays}\tСтоимость: {50 * kolvoDays}");
        }
    }
}
