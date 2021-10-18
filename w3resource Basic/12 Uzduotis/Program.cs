using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //12.Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor
            //Test Data:
            //Enter a digit: 25
            //Expected Output:
            //25 25 25 25
            //25252525
            //25 25 25 25
            //25252525

            int a = 25;

            Console.WriteLine($"{a} {a} {a} {a}");
            Console.WriteLine($"{a}{a}{a}{a}");
            Console.WriteLine($"{a} {a} {a} {a}");
            Console.WriteLine($"{a}{a}{a}{a}");

            Console.ReadLine();
        }
    }
}
