﻿using System;

namespace Day_02_Operators
{
    class Solution
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip, tax, totalCost;
            tip = meal_cost * (tip_percent / 100.0);
            tax = meal_cost * (tax_percent / 100.0);
            totalCost = meal_cost + tip + tax;
            Console.WriteLine("The total meal cost is {0} dollars.", (Math.Round(totalCost)));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);

            Console.ReadKey();
        }
    }
}
