using System;

namespace Day_01_Data_Types
{
    class Solution
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            // Declare second integer, double, and String variables.
            int a;
            double b;
            string c;

            // Read and save an integer, double, and String to your variables.
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + a);

            // Print the sum of the double variables on a new line. (scaled to 1 decimal place)
            Console.WriteLine("{0:F1}", d + b);

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + c);

            // The 's' variable above should be printed first.
        }
    }
}
