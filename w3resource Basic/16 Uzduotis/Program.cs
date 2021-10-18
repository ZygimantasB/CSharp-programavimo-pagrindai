using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //16.Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor
            //Test Data:
            //w3resource
            //Python
            //Sample Output:
            //e3resourcw
            //nythoP
            //x

            //---------- V a r i a n t a s (1) -----------------

            Console.WriteLine("V a r i a n t a s (1)");

            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));

            //---------- V a r i a n t a s (2) -----------------

            Console.WriteLine("V a r i a n t a s (2)");
            string aws = "";

            Console.Write("Iveskite zodi: ");
            aws = Console.ReadLine();

            char[] aux = new char[50];

            for (int i = 1; i <= aws.Length; i++)
            {
                aux[i] = aws[aws.Length - i];
                Console.Write(aux[i]);
            }

            //---------- V a r i a n t a s (3) -----------------

            Console.WriteLine("\nV a r i a n t a s (3) ");

            string w3 = "W3resource";
            w3 = w3.Remove(9);
            w3 = w3.Replace("W", "e");
            Console.WriteLine(w3 + "W");
            string py23 = "Python";
            py23 = py23.Remove(5);
            py23 = py23.Replace("P", "n");
            Console.WriteLine(py23 + "P" + "\nx");

            //---------- V a r i a n t a s (4) -----------------

            Console.WriteLine("V a r i a n t a s (4) ");

            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            Console.WriteLine($"{word[word.Length - 1]}" +
            $"{word.Substring(1, word.Length - 2)}" +
            $"{word[0]}");

        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
