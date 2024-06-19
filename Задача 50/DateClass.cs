using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_50
{
    class DateClass
    {

        private DateTime data;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public DateClass()
        {
            data = DateTime.Now;
        }

        /// <summary>
        /// Конструктор с параметрами (год, месяц, день)
        /// </summary>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц</param>
        /// <param name="day">День</param>
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        /// <summary>
        /// Свойство для доступа к полю data
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Метод для вычисления даты предыдущего дня
        /// </summary>
        /// <returns>Дата предыдущего дня</returns>
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        /// <summary>
        /// Метод для вычисления даты следующего дня
        /// </summary>
        /// <returns>Дата следующего дня</returns>
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }

        /// <summary>
        /// Метод для вывода информации о дате
        /// </summary>
        public void ShowDate()
        {
            Console.WriteLine($"Дата: {data.ToShortDateString()}");
        }


    }
}
