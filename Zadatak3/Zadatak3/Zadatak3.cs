using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;
            double c = 12.5;
            double d = 16.7;

            Console.WriteLine("Broj a = " + a);
            Console.WriteLine("Broj b = " + b);
            Console.WriteLine("Broj c = " + c);
            Console.WriteLine("Broj d = " + d);
            Console.WriteLine("Prosjecna vrijednost brojeva je: " + ((a + b + c + d) / 4));
            Console.ReadKey();
        }
    }
}