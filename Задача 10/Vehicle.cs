using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад._10
{
    abstract class Vehicle
    {

        private double price;
        private double speed;
        private int years;

        public double Price { get { return price; } set { price = value; } }

        public double Speed { get { return speed; } set { speed = value; } }
        public int Years { get { return years; } set { years = value; } }

        public Vehicle(double price, double speed, int years)
        {
            this.Price = price;
            this.Speed = speed;
            this.Years = years;
        }

        abstract public void Transport();


    }
}
