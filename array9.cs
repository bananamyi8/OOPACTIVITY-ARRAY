using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER9ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number #{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Multiplication Table for {numbers[i]}:");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{numbers[i]} x {j} = {numbers[i] * j}");
                }

                Console.WriteLine();
            }
        }
    }
}
