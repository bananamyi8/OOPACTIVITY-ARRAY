using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER6ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] celtemp = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Temperature #{i + 1}: ");
                celtemp[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                double fahrenheit = celtemp[i] * 9 / 5 + 32;
                string category;

                if (fahrenheit < 15) 
                {
                    category = "Cold";
                }
                else if (fahrenheit >= 30)
                {
                    category = "Warm";
                }
                else
                {
                    category = "Hot";
                }

                Console.WriteLine($"Celsius: {celtemp[i]}°C, Fahrenheit: {fahrenheit} Category: {category}");
            }
        }
    }
}
