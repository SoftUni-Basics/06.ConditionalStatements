/*  Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;
using System.Collections.Generic;

class NumberAsWords
{
    static string sentence = string.Empty;
    static bool lowercase;

    static void Main()
    {
        int number;
        string userInput;
        while (true)
        {
            Console.WriteLine("Enter value between 0 and 999!");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out number) && number >= 0 && number <= 999)
            {
                break;
            }
        }

        List<string> words = new List<string>();
        int tempNumber = number;
        int divisor = int.Parse("1".PadRight(userInput.Length, '0'));

        if (tempNumber > 19)
        {
            for (int i = divisor; i > 0 && tempNumber > 0; i /= 10)
            {
                if (tempNumber >= 100)
                {
                    words.Add(ToWords(tempNumber / i));
                    words.Add(ToWords(i));
                    if (tempNumber % i != 0)
                    {
                        words.Add("and");
                    }
                }
                else if (tempNumber >= 20 && tempNumber / i > 0)
                {
                    int tens = (tempNumber / i) * i;
                    words.Add(ToWords(tens));
                }
                else if (tempNumber <= 19)
                {
                    words.Add(ToWords(tempNumber));
                    break;
                }
                tempNumber %= i;
            }
        }
        else
        {
            words.Add(ToWords(number));
        }

        sentence = string.Join(" ", words);

        Console.WriteLine(sentence);
    }

    static string ToWords(int numbers)
    {
        string word = string.Empty;
        switch (numbers)
        {
            case 0: word = "Zero"; break;
            case 1: word = "One"; break;
            case 2: word = "Two"; break;
            case 3: word = "Three"; break;
            case 4: word = "Four"; break;
            case 5: word = "Five"; break;
            case 6: word = "Six"; break;
            case 7: word = "Seven"; break;
            case 8: word = "Eight"; break;
            case 9: word = "Nine"; break;

            case 10: word = "Ten"; break;
            case 11: word = "Еleven"; break;
            case 12: word = "Тwelve"; break;
            case 13: word = "Thirteen"; break;
            case 14: word = "Fourteen"; break;
            case 15: word = "Fifteen"; break;
            case 16: word = "Sixteen"; break;
            case 17: word = "Seventeen"; break;
            case 18: word = "Eighteen"; break;
            case 19: word = "Nineteen"; break;
            
            case 20: word = "Twenty"; break;
            case 30: word = "Thirty"; break;
            case 40: word = "Forty"; break;
            case 50: word = "Fifty"; break;
            case 60: word = "Sixty"; break;
            case 70: word = "Seventy"; break;
            case 80: word = "Eighty"; break;
            case 90: word = "Ninety"; break;
            case 100: word = "Hundred"; break;
        }

        if (lowercase)
        {
            return word.ToLower();
        }
        lowercase = true;
        return word;
    }
}
