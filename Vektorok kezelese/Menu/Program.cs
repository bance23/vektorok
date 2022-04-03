using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        public Menu()
        {

        }

        public void getMenu()
        {
            string elso = "Első menüpont";
            string masodik = "Második menüpont";
            string harmadik = "Harmadik menüpont";
            string negyedik = "Negyedik menüpont";
            string kilepes = "Kilépés";

            int beirt = Convert.ToInt32(Console.ReadLine());

            if (beirt == 1)
            {
                Console.WriteLine(elso);
            }
            if (beirt == 2)
            {
                Console.WriteLine(masodik);
            }
            if (beirt == 3)
            {
                Console.WriteLine(harmadik);
            }
            if (beirt == 4)
            {
                Console.WriteLine(negyedik);
            }
            if (beirt == 5)
            {
                Console.WriteLine(kilepes);
            }
            if (beirt != 1 & beirt != 2 & beirt != 3 & beirt != 4 & beirt != 5)
            {
                Console.WriteLine("Ön nem egy menü kódszámát írta be");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.getMenu();
            Console.ReadKey();
        
        }
    }
}
