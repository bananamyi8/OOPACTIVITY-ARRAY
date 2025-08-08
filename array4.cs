using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER4ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name #{i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Names: ");

            for (int i = 0; i < 3; i++)
            {
                string name = names[i];

                char firstChar = name[0];
                char lastChar = name[name.Length - 1];

                // Convert to uppercase strings
                string firstUpper = char.ToUpper(firstChar).ToString();
                string lastUpper = char.ToUpper(lastChar).ToString();

                // Print output
                Console.WriteLine($"Original: {name}");
                Console.WriteLine($"First Character: {firstChar} (Uppercase: {firstUpper})");
                Console.WriteLine($"Last Character: {lastChar} (Uppercase: {lastUpper})");
                Console.WriteLine();
            }
        }
    }
}