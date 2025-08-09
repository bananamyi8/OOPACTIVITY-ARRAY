using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int evenCount = 0, oddCount = 0, divisibleBy5Count = 0;

            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

                if (numbers[i] % 5 == 0)
                    divisibleBy5Count++;
            }
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
            Console.WriteLine($"Numbers divisible by 5: {divisibleBy5Count}");
        }
    }
}
