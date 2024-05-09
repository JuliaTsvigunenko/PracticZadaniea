using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Content : Book
    {
        /// <summary>
        /// Поле контент книги
        /// </summary>
        private string contented;

        /// <summary>
        /// Св-во доступа к полю контент книги
        /// </summary>
        public string Contented { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Content()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="contented">контент книги</param>
        public Content(string contented)
        {
            Contented = contented;
        }

        /// <summary>
        /// Вывод информации о контенте книги
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Cодержание книги: {Contented}");
        }


    }
}
