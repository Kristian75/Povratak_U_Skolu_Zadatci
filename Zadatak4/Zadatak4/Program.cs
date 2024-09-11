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
            // Unos vrijednosti za varijable x, y i z
            Console.Write("Unesite vrijednost za x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Unesite vrijednost za y: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Unesite vrijednost za z: ");
            int z = int.Parse(Console.ReadLine());

            // Provjera jesu li vrijednosti veće od 0
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

        // Funkcija koja provjerava je li trokut pravokutni koristeći Pitagorin teorem
        static bool IsRightTriangle(int a, int b, int c)
        {
            // Pronalaženje najveće stranice
            int max = Math.Max(a, Math.Max(b, c));

            // Provjera Pitagorinog teorema: a^2 + b^2 = c^2
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

            Console.ReadKey();
        }
    }
}
