using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_46
{
    // Интерфейс для преобразований чисел типа double
    // Этот интерфейс определяет метод Perform, который должен быть реализован
    // в любом классе, который наследует (реализует) данный интерфейс. Метод Perform
    // принимает число типа double и возвращает результат преобразования.
    public interface ICalculation
    {
        double Perform(double number); // Метод для выполнения операции над числом
    }

    // Класс для сложения числа с заданной величиной
    // Этот класс реализует интерфейс ICalculation и выполняет операцию
    // сложения. Он хранит значение, с которым будет складывать число.
    public class Add : ICalculation
    {
        // Приватное поле для хранения величины, на которую нужно увеличивать число
        private double valueToAdd;

        // Конструктор принимает величину, которую нужно добавить
        // и сохраняет её в приватное поле valueToAdd.
        public Add(double valueToAdd)
        {
            this.valueToAdd = valueToAdd;
        }

        // Реализация метода Perform из интерфейса ICalculation.
        // Метод принимает число типа double, добавляет к нему
        // значение из поля valueToAdd и возвращает результат.
        public double Perform(double number)
        {
            return number + valueToAdd; // Возвращает сумму числа и valueToAdd
        }
    }

    // Класс для умножения числа на заданный коэффициент
    // Этот класс также реализует интерфейс ICalculation, но выполняет операцию
    // умножения. Он хранит коэффициент, на который нужно умножать число.
    public class Multiply : ICalculation
    {
        // Приватное поле для хранения коэффициента умножения
        private double multiplier;

        // Конструктор принимает коэффициент умножения и сохраняет его
        // в приватное поле multiplier.
        public Multiply(double multiplier)
        {
            this.multiplier = multiplier;
        }

        // Реализация метода Perform из интерфейса ICalculation.
        // Метод принимает число типа double, умножает его на значение
        // из поля multiplier и возвращает результат.
        public double Perform(double number)
        {
            return number * multiplier; // Возвращает произведение числа и multiplier
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Метод для последовательного применения двух преобразований к числу
            // Этот метод принимает число и два преобразования (реализующих интерфейс ICalculation).
            // Он сначала применяет первое преобразование к числу, затем второе преобразование к результату
            // первого преобразования и возвращает конечный результат.
            public static double Calculate(double number, ICalculation transformation1, ICalculation transformation2)
            {
                // Выполнение первого преобразования и сохранение результата
                double result = transformation1.Perform(number);
                // Выполнение второго преобразования с результатом первого
                result = transformation2.Perform(result);
                // Возврат окончательного результата
                return result;
            }

            static void Main(string[] args)
            {
                // Пример использования метода Calculate

                // Создание преобразований
                // Создаем объект класса Add, который будет добавлять к числу 5
                ICalculation add = new Add(5);  // Добавляет 5 к числу

                // Создаем объект класса Multiply, который будет умножать число на 2
                ICalculation multiply = new Multiply(2); // Умножает число на 2

                // Исходное число, с которым будем работать
                double number = 10;

                // Применение преобразований
                // Применяем сначала add (добавление 5), затем multiply (умножение на 2)
                double result = Calculate(number, add, multiply);

                // Вывод результата на консоль
                Console.WriteLine($"Initial number: {number}"); // Исходное число: 10
                Console.WriteLine($"After adding 5: {add.Perform(number)}"); // После добавления 5: 15
                Console.WriteLine($"After multiplying by 2: {multiply.Perform(add.Perform(number))}"); // После умножения на 2: 30
                Console.WriteLine($"Final result: {result}"); // Окончательный результат: 30
            }
        }
    }
}
