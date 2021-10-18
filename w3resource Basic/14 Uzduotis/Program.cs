using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
            //Test Data:
            //Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            Console.WriteLine("Iveskite oro temperatura pagal celciju");
            double temperatura = double.Parse(Console.ReadLine());

            double kelvimas = temperatura + 273.15;
            Console.WriteLine($"Kelvimas: {kelvimas}");

            double farenheitas = temperatura * 1.8 + 32;
            Console.WriteLine($"Farenheitas: {farenheitas}");

            Console.ReadLine();

        }
    }
}
