using System;

namespace Day_06_Review
{
    class Solution
    {
        static void Main(string[] args)
        {
            string result = "";
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string S = Console.In.ReadLine();
                int max = S.Length;
                string part1 = "";
                string part2 = "";
                for (int j = 0; j < max; j++)
                {
                    if (j % 2 == 0)
                        part1 += S[j];
                    else
                        part2 += S[j];
                }
               result = result + (part1 + " " + part2 + "\n");
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
