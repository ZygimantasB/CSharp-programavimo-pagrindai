using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //21.Write a C# program to check the sum of the two given
            //integers and return true if one of the integer is 20 or if their sum is 20.

            //---------- V a r i a n t a s (1) ----------------- mano variantas

            Console.WriteLine("V a r i a n t a s (1)");

            bool patikra = true;

            Console.WriteLine("Irasykite skaiciu");
            double skaicius1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu");
            double skaicius2 = double.Parse(Console.ReadLine());

            double suma = skaicius1 + skaicius2;

            if (skaicius1 > 20 || skaicius2 > 20 || suma > 20)
            {
                Console.WriteLine(patikra);
            }
            else
            {
                Console.WriteLine("Nei Skaicius1 ir Skaicius2, bei jus suma nera daugiau nei 20");
            }

            //---------- V a r i a n t a s (2) ----------------- 

            Console.WriteLine("V a r i a n t a s (2)");

            int x, y;
            int result;

            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));

            Console.ReadKey();
        }
    }
}
