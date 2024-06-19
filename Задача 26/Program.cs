using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TourFirm> touristfirms = new List<TourFirm>();
            touristfirms.Add(new TourFirm("Тиратекс", 2000, "A13B6", 10000));
            touristfirms.Add(new TourFirm("Идемицу", 2010, "B78I9", 0));
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine(" 1. Поиск ИНН и прибыли фирмы");
                Console.WriteLine(" 2. Сумарная прибыль всех фирм");
                Console.WriteLine(" 3. Наибольшая прибыль");
                Console.WriteLine(" 4. Удаление фирм");
                Console.WriteLine(" 5. Добавление новой фирмы");
                Console.WriteLine(" 6. Вывести все фирмы");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 7. Выйти");
                Console.ResetColor();
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {

                    case 1:
                        Console.Clear();
                        Console.Write("Введите название фирмы: ");
                        string names = Console.ReadLine();
                        foreach (var elem in touristfirms)
                        {
                            if (elem.Name == names)
                            {
                                Console.WriteLine($"ИНН фирмы:  {elem.Inn};Прибыль:  {elem.Profit}$");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"Такой фирмы нет  {names}\n");
                                Console.ResetColor();
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        double totalprofit = 0;
                        foreach (var elem in touristfirms)
                        {
                            totalprofit += elem.Profit;
                        }
                        Console.WriteLine($"Сумма прибыли всех фирм :  {totalprofit}");
                        break;
                    case 3:
                        Console.Clear();
                        touristfirms.Sort();
                        foreach (var elem in touristfirms)
                        {
                            Console.WriteLine($"Наибольшую прибыль имеет: {touristfirms[touristfirms.Count - 1].Name}  {touristfirms[touristfirms.Count - 1].Profit}");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        TourFirm tofirm = null;
                        foreach (var elem in touristfirms)
                        {
                            if (elem.Profit == 0)
                            {
                                tofirm = elem;
                            }
                        }
                        touristfirms.Remove(tofirm);
                        Console.WriteLine("Обонкротившееся фирмы были удалены из списка");
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Введите название:");
                        string name = Console.ReadLine();
                        Console.Write("Введите год создания:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите ИНН:");
                        string inn = Console.ReadLine();
                        Console.Write("Введите прибыль:");
                        double profit = Convert.ToDouble(Console.ReadLine());
                        TourFirm firm = new TourFirm(name, year, inn, profit);
                        touristfirms.Add(firm);
                        break;
                    case 6:
                        Console.Clear();
                        touristfirms.Sort();
                        foreach (var elem in touristfirms)
                        {
                            elem.Info();
                        }
                        break;
                    case 7: return;
                    default: Console.WriteLine("Повторите"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
