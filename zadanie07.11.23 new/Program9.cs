using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите тип показа (премьера, обычный, льготный): ");
            string showType = Console.ReadLine();

            Console.Write("Введите количество рядов: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            switch (showType)
            {
                case "премьера":
                    totalIncome = rows * columns * 600;
                    break;
                case "обычный":
                    totalIncome = rows * columns * 410;
                    break;
                case "льготный":
                    totalIncome = rows * columns * 250;
                    break;
                default:
                    Console.WriteLine("Ошибка! Некорректный тип показа.");
                    return;
            }

            Console.WriteLine($"Общий доход от билетов: {totalIncome} руб.");

        }
    }
}
    

