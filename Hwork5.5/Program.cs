using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int[,] t = new int[a, b];

            for (int i = 0; i < a; i += 2)
            {
                for (int j = 0; j < b; j += 2)
                {
                    t[i, j] = 1;
                }
            }
            for (int i = 1; i < a; i += 2)
            {
                for (int j = 0; j < b; j += 2)
                {
                    t[i, j] = 0;
                }
            }
            for (int i = 0; i < a; i += 2)
            {
                for (int j = 1; j < b; j += 2)
                {
                    t[i, j] = 0;
                }
            }
            for (int i = 1; i < a; i += 2)
            {
                for (int j = 1; j < b; j += 2)
                {
                    t[i, j] = 1;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
