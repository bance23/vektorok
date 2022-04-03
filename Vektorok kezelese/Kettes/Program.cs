using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        public Kettes()
        {

        }
        public void getKettes()
        {
            Console.WriteLine("Szia!");
            Console.WriteLine("Kérlek írj be egy számot!");

            int beirt = Convert.ToInt32(Console.ReadLine());

            string binaris = Convert.ToString(beirt, 2);

            Console.WriteLine(binaris);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kettes kettes = new Kettes();
            kettes.getKettes();
            Console.ReadKey();
        }
    }
}
