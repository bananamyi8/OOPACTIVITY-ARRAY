using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER20ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter word #{i + 1}: ");
                words[i] = Console.ReadLine();
            }

            foreach (string word in words)
            {
                char[] arr = word.ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);

                if (word.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"{word} is Palindrome");
                else
                    Console.WriteLine($"{word} is Not a Palindrome");
            }
        }
    }
}