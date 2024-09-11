using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            Console.WriteLine("Broj a = " + a);
            Console.WriteLine("Broj b = " + b);
            Console.WriteLine("Podijeljen broj = " + (a / b));
            Console.WriteLine("Ostatak = " + (a % b));
            Console.ReadKey();

        }

    }
}