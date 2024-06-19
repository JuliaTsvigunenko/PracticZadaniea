using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    // Класс TXTHandler, наследующий AbstractHandler и реализующий методы
    class TXTHandler : AbstractHandler
    {
        /// <summary>
        /// Переопределенный метод открытия
        /// </summary>
        public override void Open()
        {
            // Вывод сообщения об открытии TXT документа
            Console.WriteLine("Open document format - TXT");
        }

        /// <summary>
        /// Переопределенный метод создания
        /// </summary>
        public override void Create()
        {
            // Вывод сообщения о создании TXT документа
            Console.WriteLine("Create document format - TXT");
        }

        /// <summary>
        /// Переопределенный метод изменения
        /// </summary>
        public override void Change()
        {
            // Вывод сообщения об изменении TXT документа
            Console.WriteLine("Change document format - TXT");
        }

        /// <summary>
        /// Переопределенный метод сохранения
        /// </summary>
        public override void Save()
        {
            // Вывод сообщения о сохранении TXT документа
            Console.WriteLine("Save document format - TXT");
        }
    }
}
