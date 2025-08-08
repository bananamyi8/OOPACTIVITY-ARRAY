using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER14ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] totals = new int[5];
            int[] studentIndex = { 0, 1, 2, 3, 4 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter 3 grades for Student {i + 1}:");
                int total = 0;

                for (int j = 0; j < 3; j++)
                {
                    int grade;
                    while (true)
                    {
                        Console.Write($"  Grade {j + 1}: ");
                        grade = Convert.ToInt32(Console.ReadLine());

                        if (grade >= 0 && grade <= 100)
                            break;
                        else
                            Console.WriteLine("    Invalid! Grade must be 0–100.");
                    }

                    total += grade;
                }

                totals[i] = total;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (totals[j] > totals[i])
                    {
                        int temp = totals[i];
                        totals[i] = totals[j];
                        totals[j] = temp;

                        int tempIndex = studentIndex[i];
                        studentIndex[i] = studentIndex[j];
                        studentIndex[j] = tempIndex;
                    }
                }
            }

            Console.WriteLine("\nStudent Rankings:");
            for (int rank = 0; rank < 5; rank++)
            {
                Console.WriteLine($"Rank {rank + 1}: Student {studentIndex[rank] + 1} - Total: {totals[rank]}");
            }
        }
    }
}
