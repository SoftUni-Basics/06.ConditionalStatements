/*  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        double[] values = new double[3];
        int negative = 0;
        int zeroValue = 0;

        for (int i = 0; i < values.Length; i++)
        {
            Console.Write("Enter real value for {0}:  ", (char)(65 + i));
            values[i] = double.Parse(Console.ReadLine());
            if (values[i] < 0)
            {
                negative++;
            }
            else if (values[i] == 0)
            {
                zeroValue++;
            }
        }

        if (zeroValue > 0)
        {
            Console.WriteLine("Result == 0");
        }
        else if (negative % 2 == 1)
        {
            Console.WriteLine("Result == '-'");
        }
        else
        {
            Console.WriteLine("Result == '+'");
        }
    }
}
