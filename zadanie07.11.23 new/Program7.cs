using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ввод данных
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            // Проверка корректности данных
            if (n > m)
            {
                Console.WriteLine("Ошибка: n должно быть меньше или равно m.");
                return;
            }
            if (s <= n)
            {
                Console.WriteLine("Ошибка: s должно быть больше или равно n.");
                return;
            }

            // Цикл для печати чисел
            for (int i = m; i >= n; i--)
            {
                if (i = m; i >= n; i--)
        {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    // Проверка числа остановки
                    if (i == s)
                    {
                        break;
                    }

                    // Печать числа
                    Console.WriteLine(i);
                }
            }
        }
    }
}




