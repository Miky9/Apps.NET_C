using System;
using System.Collections.Generic;
using System.IO;

namespace Day_08_Dictionaries_and_Maps
{
    class Solution
    {
        static void Main(string[] args)
        {
            //creating dictionary with n items
            int n = Convert.ToInt32(Console.ReadLine());

            IDictionary<string, int> dict = new Dictionary<string, int>();

            for (int j = 1; j <= n; j++)
            {
                string line = Console.ReadLine();
                line.Trim();
                line += " ";
                
                string[] tokens = line.Split(' ');
                string name = tokens[0];
                if (tokens[1] != "")
                {
                    int phone = int.Parse(tokens[1]);
                    dict.Add(name, phone);
                }
                else
                {
                    int phone = 0;
                    dict.Add(name, phone);
                }
                
            }

            //x inputs
            List<string> temp_list = new List<string>();
            string temp_line = "";

            while (true)
            {
                    temp_line = Console.ReadLine();
                    if (!string.IsNullOrEmpty(temp_line))
                        temp_list.Add(temp_line);
                    else
                        break;
            }

            //output
            foreach (string item in temp_list)
            {
                try
                {
                    Console.WriteLine("{0}={1}", item, dict[item]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Not found");
                    //throw;
                }
            }


            Console.ReadKey();
        }
    }
    
}