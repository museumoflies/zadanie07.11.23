using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод числа n
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            // Вывод чисел в виде пирамиды
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                    if (count > n)
                    {
                        break;
                    }
                }

                Console.WriteLine();
                if (count > n)
                {
                    break;
                }
            }
        }
    }
}
    

