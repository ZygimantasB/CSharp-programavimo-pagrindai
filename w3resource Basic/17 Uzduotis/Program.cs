using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //17.Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //TThe quick brown fox jumps over the lazy dog.T

            //---------- V a r i a n t a s (1) -----------------
            Console.WriteLine("V a r i a n t a s (1)");

            string str;
            int l = 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }

            //---------- V a r i a n t a s (2) -----------------
            Console.WriteLine("V a r i a n t a s (2)");
            Console.WriteLine("Enter a word : ");
            string word = Console.ReadLine();
            string firstCharacter = word.Substring(0, 1);
            string newWord = (firstCharacter + word + firstCharacter);
            Console.WriteLine(newWord);

            //---------- V a r i a n t a s (3) -----------------
            Console.WriteLine("V a r i a n t a s (3)");

            Console.WriteLine("type in a sentence");
            string sentence = Console.ReadLine();
            char[] lettersInSentence = sentence.ToCharArray();
            Console.WriteLine(lettersInSentence[0] + sentence + lettersInSentence[0]);

            //---------- V a r i a n t a s (3) -----------------
            Console.WriteLine("V a r i a n t a s (3)");

            Console.WriteLine("Enter a word: ");
            string words = Console.ReadLine();

            Console.WriteLine(words[0] + words + words[0]);


            Console.ReadLine();
        }
    }
}
