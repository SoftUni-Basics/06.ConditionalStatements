/*  Write a program that finds the biggest of three numbers.
*/

using System;
using System.Linq;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double[] values = new double[3];
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write("Enter real value for {0}:  ", (char)(65 + i));
            values[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Biggest is {0}",values.Max());
    }
}
