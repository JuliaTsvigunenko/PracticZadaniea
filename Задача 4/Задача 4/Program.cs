using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Address
            Addres myAddress = new Addres();

            // Заполняем поля экземпляра
            myAddress.Index = "123456";
            myAddress.Country = "Россия";
            myAddress.City = "Москва";
            myAddress.Street = "Тверская";
            myAddress.House = "1";
            myAddress.Apartment = "10";

            // Выводим на экран значения полей
            Console.WriteLine("Почтовый адрес:");
            Console.WriteLine("Индекс: " + myAddress.Index);
            Console.WriteLine("Страна: " + myAddress.Country);
            Console.WriteLine("Улица: " + myAddress.City);
            Console.WriteLine("Дом: " + myAddress.House);
            Console.WriteLine("Квартира: " + myAddress.Apartment);


            //2-ой вариант решения

            //Address myAddress = new Address
            //{
            //    Index = "123456",
            //    Country = "Россия",
            //    City = "Москва",
            //    Street = "Тверская",
            //    House = "1",
            //    Apartment = "10"
            //};

            //Console.WriteLine("Почтовый адрес:");
            //Console.WriteLine(myAddress.ToString());

            Console.ReadKey();
        }
       
    }
}
