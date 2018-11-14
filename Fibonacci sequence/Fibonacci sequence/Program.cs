using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence
{
    class Program
    {
        static void Fibonacci(int n)
        {
            UInt64 f1, f2, t;
            f1 = 1;
            f2 = 0;
            for (int i = 1; i <= n; i++)
            {
                t = f1;
                f1 = f2;
                f2 = f2 + t;
                Console.WriteLine(f2);
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Enter Number For Fibonacci :");
            n = int.Parse(Console.ReadLine());
            Fibonacci(n);
            Console.ReadKey();
        }
    }
}
