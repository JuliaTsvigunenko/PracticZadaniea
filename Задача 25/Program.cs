using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            InsuranceClient[] insuranceClients = new InsuranceClient[]
        {
            new InsuranceClient("John Doe", "Car", 2500),
            new InsuranceClient("Jane Smith", "Health", 1500),
            new InsuranceClient("Bob Johnson", "Car", 1800),
            new InsuranceClient("Alice Brown", "Home", 3000),
            new InsuranceClient("Tom White", "Car", 2200)
        };

            Console.WriteLine("Клиенты, застраховавшие автомобиль на сумму, превышающую 2000 рублей:");
            foreach (var client in insuranceClients)
            {
                if (client.InsuranceType == "Car" && client.InsuranceAmount > 2000)
                {
                    Console.WriteLine(client.GetClientInfo());
                }
            }

            int carInsuranceCount = 0;
            foreach (var client in insuranceClients)
            {
                if (client.InsuranceType == "Car")
                {
                    carInsuranceCount++;
                }
            }
            Console.WriteLine($"\nКоличество клиентов с автомобильной страховкой: {carInsuranceCount}");

            Console.ReadLine();
        }
    }
    
}
