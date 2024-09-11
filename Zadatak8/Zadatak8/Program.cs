using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Uneseni broj mora biti nenegativan.");
                return;
            }

            int fibonacciN = Fibonacci(n);

            Console.WriteLine($"Fibonaccijev broj na poziciji {n} je: {fibonacciN}");
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int prev = 0, curr = 1, next = 0;

            for (int i = 2; i <= n; i++)
            {
                next = prev + curr;
                prev = curr;
                curr = next;
            }

            return curr;

            Console.ReadKey();
        }
    }
}
