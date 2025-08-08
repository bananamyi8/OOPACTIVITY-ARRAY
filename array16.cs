using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER16ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] symptoms = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter symptom for Patient " + (i + 1) + ": ");
                    symptoms[i] = Console.ReadLine().ToLower();  
                }

                for (int i = 0; i < 5; i++)
                {
                    string symptom = symptoms[i];

                    if (symptom == "fever" || symptom == "cough")
                    {
                        Console.WriteLine("Patient " + (i + 1) + " → General Medicine");
                    }
                    else if (symptom == "injury" || symptom == "burn")
                    {
                        Console.WriteLine("Patient " + (i + 1) + " → Emergency");
                    }
                    else
                    {
                        Console.WriteLine("Patient " + (i + 1) + " → Refer to Specialist");
                    }
                }
            }
        }
}