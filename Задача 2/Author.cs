using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Author : Book
    {
        /// <summary>
        /// Св-во к полю автор
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Без параметров конструктор
        /// </summary>
        public Author()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="autor">автор</param>
        public Author(string autor)
        {
            Autor = autor;
        }

        /// <summary>
        /// Метод для вывода информации об авторе
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Автор: {Autor}");
        }
    }
}
