using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Tekst = "Ja sam djevojka sa sela.";
            string TekstBezRazmaka = Tekst.Replace(' ', '_');

            Console.WriteLine("Tekst: " + Tekst);
            Console.WriteLine("Tekst bez razmaka: " + TekstBezRazmaka);
            Console.ReadKey();
        }
    }
}