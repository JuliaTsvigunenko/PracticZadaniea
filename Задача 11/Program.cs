using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ключ доступа (pro или exp):");
            string key = Console.ReadLine();

            DocumentWorker docWorker;

            // Создаем экземпляр соответствующего класса в зависимости от ключа
            if (key == "pro")
            {
                docWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                docWorker = new ExpertDocumentWorker();
            }
            else
            {
                docWorker = new DocumentWorker(); // Бесплатная версия
            }

            // Пример использования методов в зависимости от выбранной версии
            docWorker.OpenDocument();
            docWorker.EditDocument();
            docWorker.SaveDocument();

            Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
        }

    }
}

