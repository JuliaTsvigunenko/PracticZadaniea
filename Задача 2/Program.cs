using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Title title = new Title("Война и мир");
            title.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Author author = new Author("Л.Н.Толстой");
            author.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Green;
            Content content = new Content("Русское общество в эпоху войн против Наполеона в 1805—1812 годах. ");
            content.ShowInfo();



        }
    }
}
