using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    // Определение абстрактного базового класса AbstractHandler
    abstract class AbstractHandler
    {

        // Абстрактные методы, которые должны быть реализованы в производных классах
        /// <summary>
        /// Метод открытия
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Метод создания
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Метод изменения
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Метод сохранения
        /// </summary>
        public abstract void Save();
    }
}
