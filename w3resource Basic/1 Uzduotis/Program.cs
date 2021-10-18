using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
            //Expected Output :
            //Hello: Alexandra Abramov
            Console.WriteLine("Jusu vardas");
            string vardas = Console.ReadLine().ToUpper();

            Console.WriteLine("Jusu pavarde");
            string pavarde = Console.ReadLine().ToUpper();

            Console.WriteLine($"Hello: {vardas} {pavarde}");

            Console.ReadLine();
        }
    }
}
