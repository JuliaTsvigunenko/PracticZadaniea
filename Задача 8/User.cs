using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class User
    {

        // Поля класса User
        private string login;          // Логин пользователя
        private string firstName;      // Имя пользователя
        private string lastName;       // Фамилия пользователя
        private int age;               // Возраст пользователя
        private readonly DateTime registrationDate;  // Дата заполнения анкеты

        // Конструктор класса User для инициализации полей
        public User(string login, string firstName, string lastName, int age, DateTime registrationDate)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = registrationDate;
        }

        // Метод для вывода информации о пользователе на экран
        public void PrintUserInfo()
        {
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Дата регистрации: {registrationDate.ToShortDateString()}");
        }

    }
}
