using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 7;
            int[] array = new int[a];
            double sum = 0; // cумма 7 введенных чисел
            Console.WriteLine($"Введите 7 чисел:");
            for (int i = 0; i < a; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            double sa = sum / a; // среднее арифметическое
            Console.WriteLine($"Сумма введенных элементов:{sum}");
            Console.WriteLine($"Среднее арифметическое элементов:{sa:f2}");
            Console.ReadKey();

        }
    }
}
