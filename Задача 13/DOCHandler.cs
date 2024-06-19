using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    // Класс DOCHandler, наследующий AbstractHandler и реализующий методы
    class DOCHandler : AbstractHandler
    {
        /// <summary>
        /// Переопределенный метод открытия
        /// </summary>
        public override void Open()
        {
            // Вывод сообщения об открытии DOC документа
            Console.WriteLine("Open document format - DOC");
        }

        /// <summary>
        /// Переопределенный метод создания
        /// </summary>
        public override void Create()
        {
            // Вывод сообщения о создании DOC документа
            Console.WriteLine("Create document format - DOC");
        }

        /// <summary>
        /// Переопределенный метод изменения
        /// </summary>
        public override void Change()
        {
            // Вывод сообщения об изменении DOC документа
            Console.WriteLine("Change document format - DOC");
        }

        /// <summary>
        /// Переопределенный метод сохранения
        /// </summary>
        public override void Save()
        {
            // Вывод сообщения о сохранении DOC документа
            Console.WriteLine("Save document format - DOC");
        }

    }
}
