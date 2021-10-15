using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = (n * (n * n + 1)) / 2; // "магическая константа нормального волшебного" квадрата
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значения для {0} строки квадрата:", i + 1);
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            bool f = false;
            int d1 = 0, d2 = 0;
            for (int i = 0; i < n; i++)
            {
                int hor = 0;
                int ver = 0;
                for (int j = 0; j < n; j++)
                {
                    hor += array[i, j];
                    ver += array[j, i];
                    if (i == j)
                    {
                        d1 += array[i, j];
                    }
                    if ((i + j) == n - 1)
                    {
                        d2 += array[i, j];
                    }
                    Console.Write("{0,3} ", array[i, j]);
                }
                f = ((hor == m) && (ver == m)) ? f : true;
                Console.WriteLine();
            }
            f = ((d1 == m) && (d2 == m)) ? f : true;
            Console.WriteLine((f) ? "Не магический квадрат" : "Магический квадрат");
            Console.ReadKey();
        }
    }
}
