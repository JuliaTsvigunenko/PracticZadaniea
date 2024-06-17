using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Invoice
    {

        // Поля, инициализируемые при создании экземпляра и доступные только для чтения
        private readonly int account;     // Номер счета
        private readonly string customer; // Заказчик
        private readonly string provider; // Поставщик

        // Закрытые поля класса
        private string article;  // Наименование товара
        private int quantity;    // Количество товара

        // Конструктор класса для инициализации номера счета, заказчика и поставщика
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        // Свойство для наименования товара (с геттером и сеттером)
        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        // Свойство для количества товара (с геттером и сеттером)
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Метод для расчета стоимости заказа с НДС
        public double CalculateTotalWithVAT(double pricePerUnit, double vatRate)
        {
            double totalCost = quantity * pricePerUnit * (1 + vatRate);
            return totalCost;
        }

        // Метод для расчета стоимости заказа без НДС
        public double CalculateTotalWithoutVAT(double pricePerUnit)
        {
            double totalCost = quantity * pricePerUnit;
            return totalCost;
        }

        // Метод для получения имени заказчика
        public string GetCustomerName()
        {
            return customer;
        }

        // Метод для получения имени поставщика
        public string GetProviderName()
        {
            return provider;
        }

    }
}
