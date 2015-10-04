using System;

class CompoundInterest
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double bank = tvPrice * Math.Pow(1 + i, n);
        double friend = tvPrice * (1 + f);

        if (bank < friend)
        {
            Console.WriteLine("{0:F} Bank", bank);
        }
        else
        {
            Console.WriteLine("{0:F} Friend", friend);
        }
    }
}
