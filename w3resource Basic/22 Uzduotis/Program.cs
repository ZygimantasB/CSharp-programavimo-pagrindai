using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to check if an given integer is within 20 of 100 or 200.

            bool tiesa = true;
            bool melas = false;

            Console.WriteLine("Irasykite skaiciu");
            double skaicius = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(skaicius));

            if (Math.Abs(skaicius - 100) <= 20 || Math.Abs(skaicius - 200) <= 20)
            {
                Console.WriteLine(tiesa);
            }
            else
            {
                Console.WriteLine(melas);
            }

            Console.ReadLine();
        }
    }
}
