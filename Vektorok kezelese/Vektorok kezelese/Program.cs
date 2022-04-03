using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorok_kezelese
{
    class Sorozatok
    {
        public Sorozatok()
        {

        }

        public void getSorozat()
        {
            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("A program üdvözöl téged!");
            Console.WriteLine("Kérlek írd be a sorozat első négy tagját!:");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            bool szamtani = false;
            bool mertani = false;

            if (d - c == c - b & c - b == b - a)
            {
                szamtani = true;
                Console.WriteLine("Ez egy számtani sorozat");
            }
            else
            {
                if (d / c == c / b & c / b == b / a)
                {
                    mertani = true;
                }
                else
                    Console.WriteLine("Ez se nem számtani, se nem mértani sorozatnak nem felel meg.");
                Console.WriteLine("Ez egy mértani sorozat");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Sorozatok sorozatok = new Sorozatok();
                sorozatok.getSorozat();
                Console.ReadKey();
            }
        }
    }
}

