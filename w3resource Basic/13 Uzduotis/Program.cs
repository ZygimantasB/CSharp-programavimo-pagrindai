using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //13.Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor
            //Test Data:
            //Enter a number: 5
            //Expected Output:
            //555
            //5 5
            //5 5
            //5 5
            //555

            int a = 5;

            Console.WriteLine($"{a}{a}{a}");
            Console.WriteLine($"{a} {a}");
            Console.WriteLine($"{a} {a}");
            Console.WriteLine($"{a} {a}");
            Console.WriteLine($"{a}{a}{a}");

            Console.ReadLine();
        }
    }
}
