using System;
using System.Collections.Generic;

class EncryptTheMessages
{
    static string ReplaceSpecialSymbols(string word)
    {
        word = word.Replace(' ', '+').Replace(',', '%').Replace('.', '&').Replace('?', '#').Replace('!', '$');
        return word;
    }
    static string Encrypting(string word)
    {
        string encrypted = string.Empty;

        foreach (var ch in word)
        {
            if ((ch >= 65 && ch <= 77) || (ch >= 97 && ch <= 109))
            {
                encrypted += Convert.ToString((char)(ch + 13));
            }
            else if ((ch >= 78 && ch <= 90) || (ch >= 110 && ch <= 122))
            {
                encrypted += Convert.ToString((char)(ch - 13));
            }
            else
            {
                encrypted += Convert.ToString((char)(ch));
            }
        }
        return encrypted;
    }
    static string ReverseMessage(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {
        List<string> messages = new List<string>();
        int msgCounter = 0;
        string input = string.Empty;

        bool start = true;
        do
        {
            input = Console.ReadLine();
            if (input == "START" || input == "start")
            {
                start = false;
            }
        } while (start);

        while (true)
        {
            input = Console.ReadLine();

            if (input == "END" || input == "end")
            {
                break;
            }
            else if (input != string.Empty)
            {
                string encrypted = input;
                string replacedSpecial = ReplaceSpecialSymbols(encrypted);
                string replacedLetters = Encrypting(replacedSpecial);

                string reversed = ReverseMessage(replacedLetters);
                messages.Add(reversed);
                msgCounter++;
            }
        }
        if (msgCounter > 0)
        {
            Console.WriteLine("Total number of messages: {0}", msgCounter);
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }
        else
        {
            Console.WriteLine("No message received.");
        }
    }
}
