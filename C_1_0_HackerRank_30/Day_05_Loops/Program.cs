using System;

namespace Day_5_Loops
{
    class Solution
    {
        static string MultiplicationTable(int n)
        {
            string result = "";
            for (int j = 1; j <= 10; j++)
            {
                //result = result + string.Format("{0} x {1} = {2}\n", n, j, n * j);
                result += $"{n} x {j} = {n*j}\n";
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MultiplicationTable(n));

            Console.ReadKey();
        }
    }
}
