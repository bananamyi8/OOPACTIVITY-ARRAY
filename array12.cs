using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER12ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };

            float[] sales = new float[12];

            // Get sales input
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter sales for {months[i]}: ");
                sales[i] = float.Parse(Console.ReadLine());
            }

            float total = 0;
            int highest = 0;
            int lowest = 0;

            for (int i = 0; i < 12; i++)
            {
                total += sales[i];
                if (sales[i] > sales[highest]) highest = i;
                if (sales[i] < sales[lowest]) lowest = i;
            }

            float average = total / 12;

            Console.WriteLine($"Highest Sales: ${sales[highest]:F2} in {months[highest]}");
            Console.WriteLine($"Lowest Sales:  ${sales[lowest]:F2} in {months[lowest]}");
            Console.WriteLine($"Average Sales:  ${average:F2}");
        }
    }

}
