using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //3resource

            //string zodis = "w3resource";

            //Console.WriteLine(zodis.Replace('3', ' ').Trim());
            //Console.WriteLine(zodis.Replace('e', ' ').Trim());
            //Console.WriteLine(zodis.Replace('w', ' ').Trim());

            //---------- V a r i a n t a s (1) -----------------

            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));

            //---------- V a r i a n t a s (2) -----------------
            Console.WriteLine("------------------------------------------");
            string word1 = "w3resource";
            string word2 = word1.Remove(1, 1);
            string word3 = word1.Remove(9);
            string word4 = word1.Remove(0, 1);
            Console.WriteLine("Test Data = " + word1);
            Console.WriteLine(word2);
            Console.WriteLine(word3);
            Console.WriteLine(word4);

            //---------- V a r i a n t a s (3) -----------------

            Console.WriteLine("------------------------------------------");
            string word = "w3resource";
            string w1, w2, w3;
            w1 = word.Remove(1, 1);
            w2 = word.Substring(0, word.Length - 1);
            w3 = word.Substring(1);
            Console.WriteLine($"{w1}\n{w2}\n{w3}");

            //---------- V a r i a n t a s (4) -----------------

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Test Data: \n");
            string MyString = "w3resource";
            Console.WriteLine(MyString.Remove(1, 2));

            string MyString2 = "w3resource";
            Console.WriteLine(MyString2.Remove(8));

            string MyString3 = "w3resource";
            Console.WriteLine(MyString3.Remove(0, 1));

            //---------- V a r i a n t a s (5) -----------------
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter a word:");
            var input = Console.ReadLine();
            Console.WriteLine("Character you want to remove:");
            var input2 = (Console.ReadLine());
            var index = input.IndexOf(input2);

            //Console.WriteLine("remove {0} character:{1}", index, input.Remove(index, 1));
            Console.WriteLine($"{index}, { input.Remove(index, 1)}");

            Console.ReadKey();
        }
            public static string remove_char(string str, int n)
            {
                return str.Remove(n, 1);
            }
        }
    
}
