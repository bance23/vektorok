using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        public Lotto()
        {

        }

        public void getLotto()
        {
            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                array[i] = random.Next(1, 91);
                for (int j = 0; j < 5; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (Array.IndexOf(array, i) == Array.IndexOf(array, j))
                        {

                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine("{0} {1} {2} {3} {4} ", array[0], array[1], array[2], array[3], array[4]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            lotto.getLotto();
            Console.ReadKey();
        }
    }
}
