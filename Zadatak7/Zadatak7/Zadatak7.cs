using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 2; i < 100; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Ukupan broj prostih brojeva manjih od 100 je: {count}");
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;

            Console.ReadKey();
        }
    }
}
