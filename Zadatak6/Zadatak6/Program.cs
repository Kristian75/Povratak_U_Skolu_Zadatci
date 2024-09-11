using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj članova reda: ");
            int brojClanova = int.Parse(Console.ReadLine());

            if (brojClanova <= 0)
            {
                Console.WriteLine("Broj članova mora biti veći od 0.");
                return;
            }

            double suma = 0;
            double clan = 1.0 / 3;

            for (int i = 1; i <= brojClanova; i++)
            {
                suma += clan;
                clan /= 3;
            }

            Console.WriteLine($"Suma reda s {brojClanova} članova iznosi: {suma}");

            Console.ReadKey();
        }
    }
}
