using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_2_pakartojimas
{
    class Teigiami_skaiciai
    {
        public int Skaicius1;
        public int Skaicius2;
        public int Skaicius3;
        public int Skaicius4;

        public Teigiami_skaiciai(int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Skaicius1 = skaicius1;
            Skaicius2 = skaicius2;
            Skaicius3 = skaicius3;
            Skaicius4 = skaicius4;
        }

        public void Sudetis(int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Console.WriteLine($"Sudetis {skaicius1 + skaicius2 + skaicius3 + skaicius4}");
        }
        public void Atimtis(int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Console.WriteLine($"Atimtis: {skaicius1 - skaicius2 - skaicius3 - skaicius4}");
        }
        public void Daugyba(int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Console.WriteLine($"Daugyba: {skaicius1 * skaicius2 * skaicius3 * skaicius4}");
        }
        public void Dalyba(int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Console.WriteLine($"Dalyba: {(double)skaicius1 / (double)skaicius2 / (double)skaicius3 / (double)skaicius4}");
        }
    }
}
