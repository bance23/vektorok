using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamRendszer
{
    class SzamRendszer
    {
        public SzamRendszer()
        {

        }

        public void getSzamRendszer() 
        {
            Console.WriteLine("Szia!");

            Console.WriteLine("Kérlek írj be egy számot!");

            int beirt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kérlek írj be egy számot milyen számrendszerbe váltsam!");

            int szamr = Convert.ToInt32(Console.ReadLine());

            string valtott = Convert.ToString(beirt, szamr);

            Console.WriteLine(valtott);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SzamRendszer szamRendszer = new SzamRendszer();
            szamRendszer.getSzamRendszer();
            Console.ReadKey();
        }
    }
}
