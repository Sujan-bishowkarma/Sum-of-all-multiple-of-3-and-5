using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_all_multiple_of_3_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the variables.
            int Sum = 0;

            // Using loop from 1 to 100.
            for (int i = 0; i <= 100; i++)
            {
                // If the current number is a multiple of 3 and 5.
                if (i % 3 == 0 || i % 5 == 0 )
                {
                    // Add the current number to the sum.
                    Sum = Sum + i;
                }
            }
                  // Display the result
                   Console.WriteLine("The sum of all multiple of 3 and 5 from 1 to 100 is : " + Sum);
                    Console.ReadKey();

        }
    }
}
