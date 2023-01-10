using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Processes
    {
        public static string GetNumerals(int number)
        {
            Dictionary<int, string> romanNumerals = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
            var result = "";
            foreach (var value in romanNumerals.Keys.OrderByDescending(val => val))
            {
                while (number >= value)
                {
                    result += romanNumerals[value];
                    number -= value;
                }
            }
            return result;
        }
        public static void Stop()
        {
            Environment.Exit(0);
        }
    }
}
