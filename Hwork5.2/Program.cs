using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Массив из 15 элементов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.WriteLine($"{i}){array[i]}");
            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                else if (a < min)
                {
                    min = a;
                }
            }
            int sum = min + max;
            Console.WriteLine($"Максимальное число:{max}");
            Console.WriteLine($"Минимальное число:{min}");
            Console.WriteLine($"Сумма минимального и максимального чисел:{sum}");
            Console.ReadKey();
        }
    }
}
