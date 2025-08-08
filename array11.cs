using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER11ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int[] ages = new int[10];

            Console.WriteLine("Enter your name: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\nEnter name #{i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter age of {names[i]}: ");
                int age = int.Parse(Console.ReadLine());

                while (age < 0 || age > 120)
                {
                    Console.Write("Invalid age. Please enter a valid age (0–120): ");
                    age = int.Parse(Console.ReadLine());
                }

                ages[i] = age;
            }

            for (int i = 0; i < 10; i++)
            {
                if (i > 18 && i > 30)
                    Console.Write("Young Voter");
                else if (i < 31 && i > 59)
                    Console.Write("Mid-Age Voter.");
                else if (i < 60)
                    Console.Write("Senior Voter.");
                else if (i > 0)
                    Console.Write("Invalid Output.");
            }
        }
    }
}
