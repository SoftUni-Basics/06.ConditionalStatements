/*  Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
    If the variable is int or double, the program increases it by one. 
    If the variable is a string, the program appends "*" at the end. 
    Print the result at the console.
    Use switch statement.
*/

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        int userChioce = UserInput();
        if (userChioce == 1)
        {
            while (true)
            {
                Console.Write("Please enter a integer: ");
                string value = Console.ReadLine();
                int integer;
                bool checker = int.TryParse(value, out integer);
                if (checker)
                {
                    Console.WriteLine("{0} is increases by one --> {1}", integer, integer + 1);
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        else if (userChioce == 2)
        {
            while (true)
            {
                Console.Write("Please enter a floating value: ");
                string value = Console.ReadLine();
                double floating;
                bool checker = double.TryParse(value, out floating);
                if (checker)
                {
                    Console.WriteLine("{0} is increases by one --> {1}", floating, floating + 1);
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        else
        {
            Console.Write("Say something: ");
            string str = Console.ReadLine();
            Console.WriteLine(str + "*");
        }
        Console.WriteLine();
    }

    static int UserInput()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string input = Console.ReadLine();
            bool correct = int.TryParse(input, out choice);
            if (choice >= 1 && choice <= 3)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
            }
        }
        return choice;
    }
}