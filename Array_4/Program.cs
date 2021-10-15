using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int s = 0;
            for (int i = 0; i < n;)
            {
                s = ((array[i] % 2 != 0) && (array[i] > 0)) ? ++s : s;
                i += 2;
            }
            Console.WriteLine();
            Console.WriteLine("{0} - количество нечетных положительных элементов, имеющих четные индексы", s);
            Console.ReadKey();
        }
    }
}
