using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_10
{
    internal class Program
    {
        public static int FindNthDigit(int number, int index)
        {
            // Начальное значение индекса
            int currentDigitIndex = 1;

            // Цикл для поиска N-й цифры
            while (number != 0)
            {
                // Проверка индекса
                if (currentDigitIndex == index)
                {
                    // Возврат цифры
                    return number % 10;
                }

                // Удаление последней цифры
                number = number / 10;

                // Увеличение индекса
                currentDigitIndex++;
            }

            // Возврат 0, если цифра не найдена
            return 0;
        }
        static void Main(string[] args)
        {
            // Ввод числа и индекса
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            // Нахождение N-й цифры
            int digit = FindNthDigit(number, index);

            // Вывод результата
            Console.WriteLine(digit);
        }
    }



}

