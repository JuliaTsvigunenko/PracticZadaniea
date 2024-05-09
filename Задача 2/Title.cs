using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Title : Book
    {
        /// <summary>
        /// Поле название книги
        /// </summary>
        private string name;

        /// <summary>
        /// Св-во доступа к полю навзание книги
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Title()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        public Title(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Метод для вывода информации о названии книги
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Название книги:{Name}");
        }


    }
}
