using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //18.Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
            //Sample Output:
            //Input first integer:
            //            -5
            //Input second integer:
            //            25
            //Check if one is negative and one is positive:
            //True

            //---------- V a r i a n t a s (1) ----------------- mano variantas

            Console.WriteLine("V a r i a n t a s (1)");

            Console.WriteLine("Skaicius A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius B");
            int b = Convert.ToInt32(Console.ReadLine());

            bool patikrinimas = true;

            if (a > 0 && b > 0)
            {
                Console.WriteLine("Abu skaiciai yra teigiami");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("b positive " + patikrinimas);
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("a positive " +patikrinimas);
            }
            else
            {
                Console.WriteLine("Abu skaicai neigiami");
            }

            //---------- V a r i a n t a s (2) -----------------

            Console.WriteLine("V a r i a n t a s (2)");

            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));

            //---------- V a r i a n t a s (3) -----------------

            Console.WriteLine("V a r i a n t a s (3)");

            int a1 = -5, b1 = 6;
            if ((a1 < 0 && b1 > 0) || (a1 > 0 && b1 < 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
