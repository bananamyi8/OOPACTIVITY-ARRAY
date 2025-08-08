using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER1000ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter your height (in centimeter): ");
                double centimeter = double.Parse(Console.ReadLine());

                if (centimeter < 150)
                    Console.Write("Short height.");
                else if (centimeter > 170)
                    Console.Write("Average height.");
                else if (centimeter < 170)
                    Console.Write("Tall height.");
                else
                    Console.Write("ERROR!");
            }
        }
    }
}
