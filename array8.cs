using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER8ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] passwords = new string[4];

                Console.WriteLine("Enter A password:");

                for (int i = 0; i < passwords.Length; i++)
                {
                    Console.Write($"Password #{i + 1}: ");
                    passwords[i] = Console.ReadLine();
                }

                Console.WriteLine("\nPassword Validation Results:");

                for (int i = 0; i < passwords.Length; i++)
                {
                    string pwd = passwords[i];
                    bool hasUpper = false;

                    foreach (char c in pwd)
                    {
                        if (char.IsUpper(c))
                        {
                            hasUpper = true;
                            break;
                        }
                    }
                    if (pwd.Length >= 6 && hasUpper)
                        Console.WriteLine($"Password #{i + 1} is Valid");
                    else
                        Console.WriteLine($"Password #{i + 1} is Invalid");
                }
            }
        }
    }

