using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
            //Test Data:
            //Input the first number: 25
            //Input the second number: 4
            //Expected Output:
            //25 + 4 = 29
            //25 - 4 = 21
            //25 x 4 = 100
            //25 / 4 = 6
            //25 mod 4 = 1

            Console.WriteLine("Skaicius 1");
            double skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius 1");
            double skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / (double)skaicius2}");
            Console.WriteLine($"{skaicius1} % {skaicius2} = {(double)skaicius1 % (double)skaicius2}");

            Console.ReadKey();

        }
    }
}
