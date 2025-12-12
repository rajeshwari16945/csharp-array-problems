using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayRearranger
{
    public static void PrintStableEvenOdd(int[] nums)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int n in nums)
        {
            if (n % 2 == 0)
                evens.Add(n);
            else
                odds.Add(n);
        }

        int[] result = evens.Concat(odds).ToArray();

        Console.WriteLine("Rearranged array:");
        foreach (int n in result)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
