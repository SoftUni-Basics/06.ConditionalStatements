/*  Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. 
    As a result print the values a and b, separated by a space.
 */

using System;
using System.Linq;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first value(a):  ");
        double a = double.Parse(Console.ReadLine()); 
        Console.Write("Enter second value(b):  ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
