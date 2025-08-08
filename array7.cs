using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER7777777ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] candidate = { "Lucy", "Candice", "Leon" };
            string[] votes = new string[10];

            Console.Write("The Candidates are Leon, Lucy & Candice");

            int countLucy = 0, countLeon = 0, countCandice = 0;

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Vote #{i + 1}: ");
                string vote = Console.ReadLine().ToLower();

                int randomIndex = rand.Next(0, candidate.Length);
                vote = candidate[randomIndex];
                votes[i] = vote;

                Console.Write($"Vote #{i + 1}: {vote}");

                if (vote == "Lucy")
                    countLucy++;
                else if (vote == "Leon")
                    countLeon++;
                else if (vote == "Candice")
                    countCandice++;
            }
            Console.WriteLine("\nVote Totals:");
            Console.WriteLine($"Lucy: {countLucy}");
            Console.WriteLine($"Leon: {countLeon}");
            Console.WriteLine($"Candice: {countCandice}");

            string winner;
            if (countCandice > countLeon && countCandice > countLucy)
                winner = "Candice";
            else if (countLeon > countCandice && countLeon > countLucy)
                winner = "Leon";
            else if (countLucy > countCandice && countLucy > countLeon)
                winner = "Lucy";
            else
                winner = "It's a tie!";

            Console.WriteLine($"\nWinner: {winner}");
        }
    }
}