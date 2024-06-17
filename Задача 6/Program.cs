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


            // Создание объекта класса Employee с указанием фамилии и имени
            Employee emp = new Employee("Иванов", "Иван");

            // Установка должности сотрудника через свойство
            emp.Position = "Инженер";

            // Расчет оклада и налогового сбора и вывод информации
            emp.CalculateSalaryAndTax();

            Console.ReadKey();

        }
    }
}
