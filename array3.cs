using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER3ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] scores = new float[5];
            char[] grades = new char[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter score #{i + 1}: ");
                scores[i] = float.Parse(Console.ReadLine());

                if (scores[i] >= 90)
                    grades[i] = 'A';
                else if (scores[i] >= 80)
                    grades[i] = 'B';
                else if (scores[i] >= 70)
                    grades[i] = 'C';
                else if (scores[i] >= 60)
                    grades[i] = 'D';
                else
                    grades[i] = 'F';
            }

            Console.WriteLine("\nGrade Results and Feedback:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Score: {scores[i]}% - Grade: {grades[i]} - ");

                switch (grades[i])
                {
                    case 'A':
                        Console.WriteLine("Amazing!");
                        break;
                    case 'B':
                        Console.WriteLine("Good for you!");
                        break;
                    case 'C':
                        Console.WriteLine("Fair effort.");
                        break;
                    case 'D':
                        Console.WriteLine("Needs improvement.");
                        break;
                    case 'F':
                        Console.WriteLine("Please study a lot!");
                        break;
                    default:
                        Console.WriteLine("Invalid grade.");
                        break;
                }
            }
        }
    }
}