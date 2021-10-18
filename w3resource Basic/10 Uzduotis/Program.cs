using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
            //Test Data:
            //Enter first number - 5
            //Enter second number - 6
            //Enter third number - 7

            //Expected Output:
            //Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

            int x = 5;
            int y = 6;
            int z = 7;

            Console.WriteLine($"{x}, {y} and {z}, {(x+y)*z} and {x*y + y*z}");

            Console.ReadLine();

        }
    }
}
