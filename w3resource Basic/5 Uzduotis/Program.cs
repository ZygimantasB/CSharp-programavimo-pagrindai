using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //5.Write a C# Sharp program to swap two numbers. Go to the editor
            //Test Data:
            //Input the First Number : 5
            //Input the Second Number : 6
            //Expected Output:
            //After Swapping :
            //First Number : 6
            //Second Number : 5

            int c;

            int a = 5;
            int b = 6;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
