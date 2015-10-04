using System;

class Sunlight
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string topAndBottom = new string('.', (input * 3) / 2);

        Console.WriteLine("{0}*{0}", topAndBottom);

        for (int i = 1; i < input; i++)
        {
            Console.WriteLine("{0}*{1}{2}*{2}{1}*{0}", 
                new string('.', i), new string('.', (input - 1) - i), new string('.', input / 2));
        }

        PrintMiddle(input);
        Console.WriteLine(new string('*', input*3));
        PrintMiddle(input);

        for (int i = 0; i < input-1; i++)
        {
            Console.WriteLine("{0}*{1}{2}*{2}{1}*{0}", 
                new string('.', (input - 1) - i), new string('.', i), new string('.', input / 2));
        }

        Console.WriteLine("{0}*{0}", topAndBottom);
    }

    private static void PrintMiddle(int input)
    {
        for (int i = 0; i < input / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', input), new string('*', input));
        }
    }
}
