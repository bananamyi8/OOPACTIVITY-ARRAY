using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER15ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] luckyNumbers = new int[20];
                int[] winningNumbers = { 7, 13, 25, 41, 78 };

                for (int i = 0; i < 20; i++)
                {
                    Console.Write("User " + (i + 1) + ", enter your lucky number (1-99): ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num < 1 || num > 99)
                    {
                        Console.WriteLine("Invalid number! Try again.");
                        i--; 
                        continue;
                    }

                    luckyNumbers[i] = num;
                }

                bool winnerFound = false;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < winningNumbers.Length; j++)
                    {
                        if (luckyNumbers[i] == winningNumbers[j])
                        {
                            Console.WriteLine("Congrats User " + (i + 1) + "! Your number " + luckyNumbers[i] + " is a winner!");
                            winnerFound = true;
                        }
                    }
                }

                if (!winnerFound)
                    Console.WriteLine("No winners this time.");
        }
    }
}