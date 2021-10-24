using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_4_bandymas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ar_nori_kartoti = true;

            while (ar_nori_kartoti)
            {
                List<string> sarasas_zodis = new List<string>();

                Console.WriteLine("Irasyktie zodi 1");
                string zodis1 = Console.ReadLine();

                WordDatabase mano_sarasas = new WordDatabase(zodis1);

                //Console.WriteLine("Irasyktie zodi 2");
                //string zodis2 = Console.ReadLine();

                //Skaiciavimai mano_sarasiukas = new Skaiciavimai(zodis1, zodis2, sarasas_zodis);

                mano_sarasas.BandytiPridetiZodi(zodis1);

                mano_sarasas.VisiZodziai(zodis1);

            }

            Console.ReadLine();

        }
    }
}
