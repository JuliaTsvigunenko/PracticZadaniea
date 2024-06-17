using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    // Определение класса Employee
    class Employee
    {


        // Приватные поля класса для хранения данных сотрудника
        private string lastName;    // Фамилия сотрудника
        private string firstName;   // Имя сотрудника
        private string position;    // Должность сотрудника

        // Конструктор класса Employee
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Свойство для доступа к фамилии сотрудника
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Свойство для доступа к имени сотрудника
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Свойство для доступа к должности сотрудника
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Метод для расчета оклада и налогового сбора
        public void CalculateSalaryAndTax()
        {
            // Пример расчета оклада (можно изменить логику и параметры)
            double baseSalary = 50000;  // Базовая зарплата для примера
            double experienceBonus = 1000;  // Бонус за стаж для примера
            double totalSalary = baseSalary + experienceBonus;

            // Пример расчета налогового сбора (можно изменить логику)
            double taxRate = 0.13;  // Пример ставки налога
            double tax = totalSalary * taxRate;

            // Вывод информации о сотруднике, окладе и налоговом сборе
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Должность: {Position}");  // Используем свойство Position
            Console.WriteLine($"Оклад: {totalSalary:C}");  // Вывод оклада в формате валюты
            Console.WriteLine($"Налоговый сбор: {tax:C}"); // Вывод налогового сбора в формате валюты
        }


    }
}
