using RomanNumeralsApp;
using System;

namespace Application
{
    class RomanNumeralsApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number for numeral conversion");
            string input = Console.ReadLine();
            
            Console.WriteLine(Processes.ConvertToNumerals(input));
            Processes.Stop();
        }
        
        
    }
}

