using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Result
    {
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            int total = (int)Math.Round(meal_cost + tip + tax);
            Console.WriteLine(total);
        }
    }
}
