using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite URL adresu: ");
            string url = Console.ReadLine();

            if (IsValidUrl(url))
            {
                Console.WriteLine("URL adresa je ispravna.");
            }
            else
            {
                Console.WriteLine("URL adresa nije ispravna.");
            }
        }

        static bool IsValidUrl(string url)
        {
            if (!url.StartsWith("www"))
            {
                return false;
            }

            if (!url.EndsWith(".hr"))
            {
                return false;
            }

            int firstDotIndex = url.IndexOf('.');
            int lastDotIndex = url.LastIndexOf('.');

            if (firstDotIndex <= 3 || lastDotIndex >= url.Length - 3 || firstDotIndex == lastDotIndex)
            {
                return false;
            }

            return true;

            Console.ReadKey();
        }
    }
}
