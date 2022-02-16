using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, e = 1;
            Console.Write("Ввести целое число:");
            int n = int.Parse(Console.ReadLine());
            while (e <= n * 2)
            {
                s += e;
                e += 2;
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }
    }
}
