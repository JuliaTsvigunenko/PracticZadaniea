using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class InsuranceClient
    {
        public string Name { get; set; }
        public string InsuranceType { get; set; }
        public double InsuranceAmount { get; set; }

        // Конструктор для инициализации полей
        public InsuranceClient(string name, string insuranceType, double insuranceAmount)
        {
            Name = name;
            InsuranceType = insuranceType;
            InsuranceAmount = insuranceAmount;
        }

        // Метод для получения информации о клиенте
        public string GetClientInfo()
        {
            return $"Имя: {Name}, Тип страховки: {InsuranceType}, Сумма страховки: {InsuranceAmount} рублей";
        }
    }
}
