using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER17ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter 8 whole numbers:");
                for (int i = 1; i <= 8; i++)
                {
                    Console.Write("Number " + i + ": ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    bool isPrime = true;
                    if (num <= 1)
                        isPrime = false;
                    else
                    {
                        for (int j = 2; j <= num / 2; j++)
                        {
                            if (num % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }

                    string binary = Convert.ToString(num, 2);
                    string evenOdd = (num % 2 == 0) ? "Even" : "Odd";

                    Console.WriteLine($"→ {num} is {(isPrime ? "Prime" : "Not Prime")}, Binary: {binary}, {evenOdd}");
                }
        }
    }
}
