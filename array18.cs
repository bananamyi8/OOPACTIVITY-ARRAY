using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER18ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = new string[5];
            string specialChars = "!@#$%^&*";

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter password #{i + 1}: ");
                passwords[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                string pwd = passwords[i];
                bool hasUpper = false, hasDigit = false, hasSpecial = false;

                foreach (char c in pwd)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (specialChars.Contains(c)) hasSpecial = true;
                }

                if (pwd.Length < 8)
                {
                    Console.WriteLine($"Password #{i + 1}: INVALID (too short)");
                }
                else if (hasUpper && hasDigit && hasSpecial)
                {
                    Console.WriteLine($"Password #{i + 1}: STRONG");
                }
                else
                {
                    Console.WriteLine($"Password #{i + 1}: WEAK");
                }
            }
        }
    }
}