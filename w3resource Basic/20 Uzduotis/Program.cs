using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //20.Write a C# program to get the absolute value of the difference between two given numbers. 
            //Return double the absolute value of the difference if the first number is greater than second number. 

            //---------- V a r i a n t a s (1) ----------------- mano variantas

            Console.WriteLine("V a r i a n t a s (1)");

            Console.WriteLine("Irasykite skaiciu");
            double skaicius1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu");
            double skaicius2 = double.Parse(Console.ReadLine());

            double skaicius1_Min = double.MinValue;
            double skaicius1_Max = double.MaxValue;

            Console.WriteLine($"{skaicius1_Min} {skaicius1_Max}");

            //---------- V a r i a n t a s (2) ----------------- 

            Console.WriteLine("V a r i a n t a s (2)");

            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));

            //---------- V a r i a n t a s (3) -----------------
            Console.WriteLine("V a r i a n t a s (3)");

            int num1, num2;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int absValue = Math.Abs(num1 - num2);

            int compute = num1 > num2 ? absValue * 2 : absValue;

            Console.WriteLine(compute);

            Console.ReadLine();
        }

        public static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return b - a;
        }
    }
}
