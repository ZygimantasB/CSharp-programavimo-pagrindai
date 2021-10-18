using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
            //Test Data:
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15....5 * 10 = 50

            int skaicius1 = 5;

            for (int i = 0; i <= 10; i++ )
            {
                Console.WriteLine($"{skaicius1} * {i} = {skaicius1 * i}");
            }
            Console.ReadLine();
        }
    }
}
