using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int min = 50, max = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write("{0} ", array[i]);
                min = (min > array[i]) ? array[i] : min;
                max = (max < array[i]) ? array[i] : max;
            }
            Console.WriteLine();
            Console.WriteLine("{0} - сумма минимального и максимального значений", min + max);
            Console.ReadKey();
        }
    }
}