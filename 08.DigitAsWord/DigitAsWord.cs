/*  Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). 
        Print “not a digit” in case of invalid inut. 
        Use a switch statement.
*/

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit(0-9):  ");
        string value = Console.ReadLine();
        Console.WriteLine(DigitChecker(value));
    }

    static string DigitChecker(string digit)
    {
        string digitWord = null;
        switch (digit)
        {
            case "0": digitWord = "Zero"; break;
            case "1": digitWord = "One"; break;
            case "2": digitWord = "Two"; break;
            case "3": digitWord = "Three"; break;
            case "4": digitWord = "Four"; break;
            case "5": digitWord = "Five"; break;
            case "6": digitWord = "Six"; break;
            case "7": digitWord = "Seven"; break;
            case "8": digitWord = "Eight"; break;
            case "9": digitWord = "Nine"; break;
            default: digitWord = "not a digit";break;
        }
        return digitWord;
    }
}
