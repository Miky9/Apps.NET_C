using System;
using System.Collections.Generic;

namespace Day_08_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            IDictionary<string, int> dict = new Dictionary<string, int>();

            for (int j = 1; j <= n; j++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                int phone = int.Parse(tokens[1]);
                dict.Add(name, phone);
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                if (item.Key != null)
                {
                    Console.WriteLine("{0}={1}", item.Key, item.Value);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            Console.ReadKey();
        }
    }
}
