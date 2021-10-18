using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //19.Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum. Go to the editor

            //---------- V a r i a n t a s (1) ----------------- mano variantas

            Console.WriteLine("V a r i a n t a s (1)");

            Console.WriteLine("Irasykite skaiciu");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu");
            int skaicius2 = int.Parse(Console.ReadLine());

            if (skaicius1 == skaicius2)
            {
                Console.WriteLine($"({skaicius1} + {skaicius2}) * 3 = {(skaicius1 + skaicius2) * 3}");
            }
            else
            {
                Console.WriteLine("Skaiciai nera lygus");
            }

            //---------- V a r i a n t a s (2) ----------------- mano variantas

            Console.WriteLine("V a r i a n t a s (2)");

            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));

            Console.ReadKey();
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
