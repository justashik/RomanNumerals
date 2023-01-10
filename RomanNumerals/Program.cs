using RomanNumerals;
using System;

Console.WriteLine("Enter Number for numeral conversion");
string input = Console.ReadLine();

if(!InputValidation.IsNumber(input)) Processes.Stop();


int number = Convert.ToInt32(input);

if (!InputValidation.IsBetweenRange(number)) Processes.Stop();

Console.WriteLine(Processes.GetNumerals(number));
Processes.Stop();
