using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем экземпляр класса Converter и задаем курсы валют через свойства
            Converter converter = new Converter(0, 0, 0);
            converter.UsdRate = 2.62;
            converter.EurRate = 3.12;
            converter.RubRate = 0.038;

            // Примеры конвертации
            double amountBYN = 100.0;

            // Конвертация из BYN в USD
            double amountUSD = converter.ConvertFromBYN(amountBYN, "USD");
            Console.WriteLine($"{amountBYN} BYN = {amountUSD} USD");

            // Конвертация из USD в BYN
            double amountBYN2 = converter.ConvertToBYN(amountUSD, "USD");
            Console.WriteLine($"{amountUSD} USD = {amountBYN2} BYN");

            // Конвертация из BYN в EUR
            double amountEUR = converter.ConvertFromBYN(amountBYN, "EUR");
            Console.WriteLine($"{amountBYN} BYN = {amountEUR} EUR");

            // Конвертация из EUR в BYN
            double amountBYN3 = converter.ConvertToBYN(amountEUR, "EUR");
            Console.WriteLine($"{amountEUR} EUR = {amountBYN3} BYN");

            // Конвертация из BYN в RUB
            double amountRUB = converter.ConvertFromBYN(amountBYN, "RUB");
            Console.WriteLine($"{amountBYN} BYN = {amountRUB} RUB");

            // Конвертация из RUB в BYN
            double amountBYN4 = converter.ConvertToBYN(amountRUB, "RUB");
            Console.WriteLine($"{amountRUB} RUB = {amountBYN4} BYN");




            // Пример обработки исключения
            try
            {
                double amountInvalid = converter.ConvertFromBYN(amountBYN, "AUD");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
