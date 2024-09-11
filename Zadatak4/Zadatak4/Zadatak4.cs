using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite vrijednost za stranicu a: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Unesite vrijednost za stranicu b: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Unesite vrijednost za stranicu c: ");
            int z = int.Parse(Console.ReadLine());

            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Vrijednosti stranica moraju biti veće od 0.");
            }
            else if (IsRightTriangle(x, y, z))
            {
                Console.WriteLine("Vrijednosti predstavljaju stranice pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Vrijednosti ne predstavljaju stranice pravokutnog trokuta.");
            }
        }
        static bool IsRightTriangle(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));

            if (max == a)
            {
                return (b * b + c * c) == (a * a);
            }
            else if (max == b)
            {
                return (a * a + c * c) == (b * b);
            }
            else
            {
                return (a * a + b * b) == (c * c);
            }


        }
    }
}