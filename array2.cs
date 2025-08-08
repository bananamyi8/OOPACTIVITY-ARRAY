using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER2ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] fruits = new string[5];
                int appleCount = 0;

                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.Write($"Enter favorite fruit #{i + 1}: ");
                    fruits[i] = Console.ReadLine().ToLower();
                }

                for (int i = 0; i < fruits.Length; i++)
                {
                    if (fruits[i] == "apple")
                    {
                        appleCount++;
                    }
                }
                Console.WriteLine($"\nYou entered 'apple' {appleCount} time(s).");
        }
    }
}
