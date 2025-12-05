using System;
using System.Collections.Generic;

class MergeArraysRemoveDuplicates
{
    public static void getMergedArray()
    {
        Console.Write("Enter elements of first array (space-separated): ");
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.Write("Enter elements of second array (space-separated): ");
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        HashSet<int> mergedSet = new HashSet<int>();

        foreach (int n in arr1)
            mergedSet.Add(n);

        foreach (int n in arr2)
            mergedSet.Add(n);

        Console.WriteLine("\nMerged array without duplicates:");
        foreach (int n in mergedSet)
            Console.Write(n + " ");

        Console.WriteLine();
    }
}
