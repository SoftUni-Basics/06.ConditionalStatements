/*  Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
    Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise
*/
using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("Enter a type of card: ");
        string input = Console.ReadLine();

        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == input)
            {
                Console.WriteLine("Yes, it is a valid card.\r\n");
                return;
            }
        }
        Console.WriteLine("No, it is not a valid card!");
    }
}
