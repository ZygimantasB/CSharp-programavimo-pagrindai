using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_4_bandymas_2
{
    class WordDatabase
    {
        public List<string> Mano_sarasas { get; private set; }
        public string Zodis;
        private string zodis1;

        public WordDatabase (List<string> mano_sarasas, string zodis)
        {
            Mano_sarasas = mano_sarasas;
            Zodis = zodis;
        }

        public WordDatabase(string zodis1)
        {
            this.zodis1 = zodis1;
        }

        public void Zodziu_saugykla (string zodis)
        {
            Mano_sarasas = new List<string>();
            Mano_sarasas.Add(Zodis);
        }

        public void BandytiPridetiZodi(string zodis)
        {
            Mano_sarasas.Contains(zodis) = true;
        }
        public void VisiZodziai (string zodis)
        {
            foreach (var mano_sarasas in Mano_sarasas)
            {
                Console.WriteLine(mano_sarasas);
            }
        }
    }
}
