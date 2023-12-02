using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 7:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Ошибка!";
                    break;
            }

            Console.WriteLine(dayName);
        }
    }

}
    

