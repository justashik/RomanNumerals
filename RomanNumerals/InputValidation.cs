using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class InputValidation
    {
        public static bool IsNumber(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                return true;
            }
            Console.WriteLine("Enter a valid number");
            return false;
        }
        public static bool IsBetweenRange(int input)
        {
            if (input < 1 || input > 2000)
            {
                return true;
            }
            Console.WriteLine("Enter a number between 1 & 2000");
            throw new ArgumentOutOfRangeException("Number", "Enter a number between 1 & 2000");
        }
    }
}
