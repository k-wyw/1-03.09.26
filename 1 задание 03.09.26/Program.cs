using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_задание_03._09._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            while (true)  
            {
                Console.Write("Введите день: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out day))  
                {
                    if (day >= 1 && day <= 31)  
                    {
                        break;  
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! День должен быть от 1 до 31.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число.");
                }
            }

            while (true)
            {
                Console.Write("Введите месяц: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out month))
                {
                    if (month >= 1 && month <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Месяц от 1 до 12.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число.");
                }
            }

            while (true)
            {
                Console.Write("Введите год: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out year))
                {
                    if (year >= 0 && year <= 99)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Год от 0 до 99.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число.");
                }
            }

            
            int fullYear;
            if (year >= 0 && year <= 30)
                fullYear = 2000 + year;
            else
                fullYear = 1900 + year;
            string monthName;
            switch (month)
            {
                case 1: monthName = "Январь"; break;
                case 2: monthName = "Февраль"; break;
                case 3: monthName = "Март"; break;
                case 4: monthName = "Апрель"; break;
                case 5: monthName = "Май"; break;
                case 6: monthName = "Июнь"; break;
                case 7: monthName = "Июль"; break;
                case 8: monthName = "Август"; break;
                case 9: monthName = "Сентябрь"; break;
                case 10: monthName = "Октябрь"; break;
                case 11: monthName = "Ноябрь"; break;
                case 12: monthName = "Декабрь"; break;
                default: monthName = "неизвестно"; break;
            }

            Console.WriteLine($"{day} {monthName} {fullYear} год");
        }
    }
}
