﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER13ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter email " + (i + 1) + ": ");
                emails[i] = Console.ReadLine();
            }

            Console.WriteLine("\nResults:");

            for (int i = 0; i < 5; i++)
            {
                string email = emails[i];

                if (email.Contains("@") && (email.EndsWith(".com") || email.EndsWith(".edu")))
                {
                    int atIndex = email.IndexOf("@");
                    string username = email.Substring(0, atIndex);
                    Console.WriteLine("Valid: " + email + "  Username: " + username);
                }
                else
                {
                    Console.WriteLine("Invalid: " + email);
                }
            }
        }
    }
}