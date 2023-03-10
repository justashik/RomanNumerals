using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsApp
{
    public class Processes
    {
        public static string ConvertToNumerals(string input)
        {
            InputValidation.IsNumber(input);

            int number = Convert.ToInt32(input);

            InputValidation.IsBetweenRange(number);

            return GetNumerals(number);
        }
        
        public static string GetNumerals(int number)
        {
            //Dict to store the number and letter relationship
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
            foreach (var value in romanNumerals.Keys.OrderByDescending(x => x)) //iterate through values
            {
                while (number >= value)
                {
                    result += romanNumerals[value]; //add letter
                    number -= value; //subtract from current val
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
