using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Write a C# Sharp program to print the sum of two numbers.

            Console.WriteLine("Skaicius 1");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius 1");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2} ");

            Console.ReadKey();
        }
    }
}
