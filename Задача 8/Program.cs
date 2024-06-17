using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса User с указанием данных о пользователе и даты регистрации
            DateTime registrationDate = DateTime.Now.Date; // Пример: текущая дата
            User user = new User("user123", "Иван", "Иванов", 30, registrationDate);

            // Выводим информацию о пользователе на экран
            user.PrintUserInfo();

            // Ожидаем нажатия клавиши перед завершением программы
            Console.ReadLine();

        }
    }
}
