using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER19ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monthlyIncome = 25000;
            string[] categories = { "Food", "Rent", "Utilities", "Transport", "Others" };
            float[] budgets = new float[5];

            for (int i = 0; i < categories.Length; i++)
            {
                Console.Write($"Enter budget for {categories[i]}: ");
                budgets[i] = float.Parse(Console.ReadLine());
            }

            float total = 0;
            for (int i = 0; i < budgets.Length; i++)
                total += budgets[i];

            Console.WriteLine($"\nTotal Budget: {total}");

            if (total > monthlyIncome)
            {
                int maxIndex = 0;
                for (int i = 1; i < budgets.Length; i++)
                    if (budgets[i] > budgets[maxIndex])
                        maxIndex = i;

                Console.WriteLine("You are over budget!");
                Console.WriteLine($"Consider reducing expenses in: {categories[maxIndex]}");
            }
            else
            {
                Console.WriteLine("You are within budget. Good job!");
            }
        }
    }
}