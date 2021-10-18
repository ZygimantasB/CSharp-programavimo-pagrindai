using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
            //Test Data:
            //Input the first number to multiply: 2
            //Input the second number to multiply: 3
            //Input the third number to multiply: 6
            //Expected Output:
            //2 x 3 x 6 = 36

            Console.WriteLine("Skaicius 1");
            double skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius 2");
            double skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius 3");
            double skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius1} x {skaicius2} x {skaicius3} = {skaicius1 * skaicius2 * skaicius3}");

            Console.ReadKey();
        }
    }
}
