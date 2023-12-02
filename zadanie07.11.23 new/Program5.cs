using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод дня, месяца и года
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            // Проверка корректности даты
            bool dateIsValid = true;

            // Проверка дня
            if (day < 1 || day > 31)
            {
                dateIsValid = false;
            }
            // Проверка месяца
            else if (month < 1 || month > 12)
            {
                dateIsValid = false;
            }
            // Проверка февраля
            else if (month == 2 && day > 28)
            {
                dateIsValid = false;
            }
            // Проверка дней в месяце
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
            {
                dateIsValid = false;
            }

            // Вывод результата
            if (dateIsValid)
            {
                Console.WriteLine("The date is correct.");
            }
            else
            {
                Console.WriteLine("The date is incorrect.");
            }
        }
    }
}
    

