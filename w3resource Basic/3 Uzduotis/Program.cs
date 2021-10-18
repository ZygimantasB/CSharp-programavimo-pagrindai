using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a C# Sharp program to print the result of dividing two numbers.

            Console.WriteLine("Skaicius 1");
            double skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius 1");
            double skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2:0.00} ");

            Console.ReadKey();
        }
    }
}
