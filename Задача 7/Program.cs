using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создаем объект класса Invoice с указанием номера счета, заказчика и поставщика
            Invoice invoice = new Invoice(12345, "ООО Рога и копыта", "ООО Цветочек");

            // Устанавливаем наименование товара и количество товара
            invoice.Article = "Компьютерная мышь";
            invoice.Quantity = 5;

            // Цена за единицу товара
            double pricePerUnit = 3500;

            // НДС в процентах (20%)
            double vatRate = 0.2;

            // Рассчитываем стоимость заказа с НДС
            double totalWithVAT = invoice.CalculateTotalWithVAT(pricePerUnit, vatRate);

            // Рассчитываем стоимость заказа без НДС
            double totalWithoutVAT = invoice.CalculateTotalWithoutVAT(pricePerUnit);

            // Выводим информацию о заказе на экран
            Console.WriteLine("Информация о заказе:");
            Console.WriteLine($"Заказчик: {invoice.GetCustomerName()}");
            Console.WriteLine($"Поставщик: {invoice.GetProviderName()}");
            Console.WriteLine($"Наименование товара: {invoice.Article}");
            Console.WriteLine($"Количество товара: {invoice.Quantity}");
            Console.WriteLine($"Цена за единицу товара: {pricePerUnit} руб.");
            Console.WriteLine($"Стоимость заказа с НДС: {totalWithVAT} руб.");
            Console.WriteLine($"Стоимость заказа без НДС: {totalWithoutVAT} руб.");

            // Ожидаем нажатия клавиши перед завершением программы
            Console.ReadLine();


        }
    }
}
