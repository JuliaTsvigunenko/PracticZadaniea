using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class XMLHandler : AbstractHandler
    {
        /// <summary>
        /// Переопределенный метод открытия 
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Open document format - XML ");
        }
        /// <summary>
        /// Переопределенный метод создания
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Open document format - XML ");
        }
        /// <summary>
        /// Переопределенный метод изменения
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Open document format - XML ");
        }
        /// <summary>
        /// Переопределенный метод сохранения
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Open document format - XML ");
        }
    }
}
