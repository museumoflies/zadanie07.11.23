using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод чисел n и l
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите число l: ");
            int l = int.Parse(Console.ReadLine());

            // Генерация паролей
            Console.WriteLine("Все возможные пятизначные пароли:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            for (int p = Math.Max(i, j) + 1; p <= 9; p++)
                            {
                                Console.WriteLine($"{i}{j}{(char)('a' + k)}{(char)('a' + m)}{p}");
                            }
                        }
                    }
                }
            }
        }
    }
}