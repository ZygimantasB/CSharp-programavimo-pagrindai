using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30

            int a = 10;
            int b = 15;
            int c = 20;
            int d = 30;

            Console.WriteLine($"{a}, {b}, {c}, {d} = {(a+b+c+d) /4}");

            Console.ReadLine();

        }
    }
}
