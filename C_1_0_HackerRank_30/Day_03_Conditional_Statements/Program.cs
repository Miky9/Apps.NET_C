using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Day_03_Conditional_Statements
{
    class Solution
    {

        static void IsWeird(int N)
        {
            string text;
            if ((N % 2 != 0) | (N >= 6 && N <= 20))
            {
                text = "Weird";
            }
            else
            {
                text = "Not Weird";
            }
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            IsWeird(N);

            Console.ReadKey();
        }
    }
}
