using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsApp
{
    public class InputValidation
    {
        public static void IsNumber(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (!isNumber)
            {
                Console.WriteLine("The input must be a valid integer");
                throw new ArgumentOutOfRangeException("Integer", "The input must be a valid integer");
            }
            
        }
        public static void IsBetweenRange(int input)
        {
            if (input < 1 || input > 2000)
            {
                Console.WriteLine("Enter a number between 1 & 2000");
                throw new ArgumentOutOfRangeException("Integer", "Enter a number between 1 & 2000");
            }
            
        }
    }
}
