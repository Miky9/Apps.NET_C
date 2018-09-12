using System;

namespace Day_07_Arrays
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Reverse(arr);

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
