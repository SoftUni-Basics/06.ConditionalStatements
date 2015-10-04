using System;

class PetarGame
{
    static void Main()
    {
        ulong start = ulong.Parse(Console.ReadLine());
        ulong end = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();

        decimal sum = 0;
        for (ulong i = start; i < end; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        string output = sum.ToString();
        if (sum % 2 == 1)
        {
            string last = (sum % 10).ToString();
            output = output.Replace(last, replacement);
            Console.WriteLine(output);
        }
        else
        {
            string first = output[0].ToString();
            output = output.Replace(first, replacement);
            Console.WriteLine(output);
        }
    }
}
