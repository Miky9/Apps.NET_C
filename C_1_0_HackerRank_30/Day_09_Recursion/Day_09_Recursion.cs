using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

class Solution {

    // Complete the factorial function below.
    static int factorial (int n) {
        int i = 1;
        int res = 0;

        while (i <= n) {
            if (i == 1) {
                res = 1;
            } else {
                res = factorial (i - 1) * i;
            }
            i++;
        };

        return res;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());

        int result = factorial (n);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}