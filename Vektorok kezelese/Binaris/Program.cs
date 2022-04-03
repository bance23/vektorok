using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {
        public Binaris()
        {

        }

        public void getBinaris()
        {
            Console.WriteLine("A program üdvözöl téged!");
            Console.WriteLine("Kérlek írj be egy bináris számot!:");

            bool kiir = true;
            int szam = Convert.ToInt32(Console.ReadLine()), remainder, egyes = 0;

            while (szam > 0)
            {
                remainder = szam % 10;
                if (remainder > 1)
                {
                    Console.WriteLine("nem bináris számot írtál be. Átvertél. Viszlát! :(");
                    kiir = false;
                    break;
                }
                else
                {
                    egyes = egyes + remainder;
                    szam = szam / 10;
                }
            }
            if (kiir == true)
            {
                Console.WriteLine("Ennyi egyes volt a számban:{0}", egyes);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binaris binaris = new Binaris();
            binaris.getBinaris();
            Console.ReadKey();

        }
    }
}
