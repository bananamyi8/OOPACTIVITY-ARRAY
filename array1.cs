using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER1ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            int teenCount = 0;

            for (int i = 0; i < 5; i++)
            {
                int age;
                while (true)
                {
                    Console.Write($"Enter age #{i + 1} (10-99): ");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age >= 10 && age <= 99)
                    {
                        ages[i] = age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a number between 10 and 99.");
                    }
                }
            }

            Console.WriteLine("\nValid ages entered:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ages[i]);

                if (ages[i] >= 13 && ages[i] <= 19)
                {
                    teenCount++;
                }
            }

            Console.WriteLine($"\nNumber of teenagers (13–19): {teenCount}");
        }
    }
}
