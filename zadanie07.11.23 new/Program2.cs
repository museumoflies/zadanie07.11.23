using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод высоты пирамиды
        Console.Write("Введите высоту пирамиды: ");
            int height = int.Parse(Console.ReadLine());

            // Вывод пирамиды из чисел
            for (int i = 1; i <= height; i++)
            {
                // Вывод пробелов перед числами
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Вывод чисел
                for (int k = 1; k <= i; k++)
                {
                    Console.Write((k % 10) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
    

