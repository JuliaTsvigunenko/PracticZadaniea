using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>();
            while (true)
            {
                Console.Write("Введите формат файла xml, txt, doc /если вы хотите закрыть консоль, напишите (exit):  ");
                string format = Console.ReadLine();
                Console.WriteLine();
                switch (format.ToLower())
                {
                    case "xml":
                        XMLHandler handler = new XMLHandler();
                        handler.Open();
                        handler.Create();
                        handler.Change();
                        handler.Save();
                        Console.WriteLine();
                        break;
                    case "txt":
                        TXTHandler handler1 = new TXTHandler();
                        handler1.Open();
                        handler1.Create();
                        handler1.Change();
                        handler1.Save();
                        Console.WriteLine();
                        break;
                    case "doc":
                        DOCHandler handler2 = new DOCHandler();
                        handler2.Open();
                        handler2.Create();
                        handler2.Change();
                        handler2.Save();
                        Console.WriteLine();
                        break;
                    case "exit": return;
                    default:
                        Console.WriteLine("Вы ввели неверный формат!");
                        break;
                }

                Console.ReadKey();
            }
           
        }
    }
}
