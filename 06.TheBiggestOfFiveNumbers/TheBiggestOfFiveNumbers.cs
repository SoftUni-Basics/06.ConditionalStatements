/*  Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double[] values = new double[5];
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write("Enter real value for {0}:  ", (char)(65 + i));
            values[i] = double.Parse(Console.ReadLine());
        }

        if (values[0] >= values[1] && values[0] >= values[2] && values[0] >= values[3] && values[0] >= values[4])
        {
            Console.WriteLine("Biggest is {0}", values[0]);
        }
        else if (values[1] >= values[0] && values[1] >= values[2] && values[1] >= values[3] && values[1] >= values[4])
        {
            Console.WriteLine("Biggest is {0}", values[1]);
        }
        else if (values[2] >= values[0] && values[2] >= values[1] && values[2] >= values[3] && values[2] >= values[4])
        {
            Console.WriteLine("Biggest is {0}", values[2]);
        }
        else if (values[3] >= values[0] && values[3] >= values[1] && values[3] >= values[2] && values[3] >= values[4])
        {
            Console.WriteLine("Biggest is {0}", values[3]);
        }
        else
        {
            Console.WriteLine("Biggest is {0}", values[4]);
        }
    }
}
