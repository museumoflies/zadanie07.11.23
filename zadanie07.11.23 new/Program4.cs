using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Исходный массив
            int[] arr = { 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 };

            // Сортировка массива методом пузырька (Bubble Sort)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Обмен элементов
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Вывод отсортированного массива
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
    

