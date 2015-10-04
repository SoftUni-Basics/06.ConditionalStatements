/*  We are given 5 integer numbers. 
    Write a program that finds all subsets of these numbers whose sum is 0. 
    Assume that repeating the same subset several times is not a problem.
*/

using System;
using System.Linq;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int allCombinations = (int)Math.Pow(2, numbers.Length);
        var subSet = new SortedSet<string>();   // exchange this Sort-Set with List below, if you want to see all combinations(use five zeroes)
        //var subSet = new List<string>();

        for (int i = 1; i < allCombinations; i++)
        {
            string temp = Convert.ToString(i, 2).PadLeft(numbers.Length, '0');
            int result = 0;
            List<int> tempSubSet = new List<int>();

            for (int j = 0; j < temp.Length; j++)
            {
                int crntIndexes = (1 << j) & i;
                int secIndex = crntIndexes >> j;
                bool isOne = secIndex == 1;
                if (isOne)
                {
                    result += numbers[j];
                    tempSubSet.Add(numbers[j]);
                }
            }
            if (result == 0)
            {
                subSet.Add(string.Join(" + ", tempSubSet) + " = 0");
            }
            result = 0;
        }
        if (subSet.Count == 0)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            foreach (var str in subSet)
            {
                Console.WriteLine(str);
            }
        }
    }
}
