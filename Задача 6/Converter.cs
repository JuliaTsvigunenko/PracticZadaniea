using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    public class Converter
    {

        // Приватные поля для хранения курсов валют
        private double usdRate;
        private double eurRate;
        private double rubRate;

        // Публичные свойства для доступа к курсам валют
        public double UsdRate
        {
            get { return usdRate; }
            set { usdRate = value; }
        }

        public double EurRate
        {
            get { return eurRate; }
            set { eurRate = value; }
        }

        public double RubRate
        {
            get { return rubRate; }
            set { rubRate = value; }
        }

        // Конструктор класса Converter для инициализации курсов валют
        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

        // Метод для конвертации из BYN в указанную валюту
        public double ConvertFromBYN(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / usdRate;
                case "eur":
                    return amount / eurRate;
                case "rub":
                    return amount / rubRate;
                default:
                    Console.WriteLine("Указана неподдерживаемая валюта.");
                   return 0; // или другое значение по умолчанию, если необходимо
            }
        }

        // Метод для конвертации из указанной валюты в BYN
        public double ConvertToBYN(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * usdRate;
                case "eur":
                    return amount * eurRate;
                case "rub":
                    return amount * rubRate;
                default:
                    Console.WriteLine("Указана неподдерживаемая валюта.");
                return 0; // или другое значение по умолчанию, если необходимо
            }
        }


    }
}
