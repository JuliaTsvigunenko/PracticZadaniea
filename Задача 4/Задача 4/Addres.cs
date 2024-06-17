using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    public class Addres
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }


        //2-ой вариант решения

        //public string Index { get; set; }
        //public string Country { get; set; }
        //public string City { get; set; }
        //public string Street { get; set; }
        //public string House { get; set; }
        //public string Apartment { get; set; }

        //public override string ToString()
        //{
        //    return $"Индекс: {Index}, Страна: {Country}, Город: {City}, Улица: {Street}, Дом: {House}, Квартира: {Apartment}";
        //}

    }
}
