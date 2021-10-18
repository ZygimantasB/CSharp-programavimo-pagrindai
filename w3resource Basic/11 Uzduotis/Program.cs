using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
            //Test Data:
            //Enter your age - 25
            //Expected Output:
            //You look older than 25

            Console.WriteLine("Irasykite savo amziu");
            int amzius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Atrodai vyresnis nei {amzius}");

            Console.ReadLine();
        }
    }
}
