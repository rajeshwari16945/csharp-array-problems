using System;
using System.Collections.Generic;

public class TemporalMajorityDrift
{
    public static IList<int> FindTemporallyDominant(int[] arr)
    {
        int n = arr.Length;
        var result = new HashSet<int>();

        var freq = new Dictionary<int, int>();
        foreach (var v in arr)
        {
            freq[v] = freq.GetValueOrDefault(v) + 1;
        }

        var values = new List<int>();
        var counts = new List<int>();

        for (int i = 0; i < n;)
        {
            int j = i;
            while (j < n && arr[j] == arr[i]) j++;

            values.Add(arr[i]);
            counts.Add(j - i);
            i = j;
        }

        int m = values.Count;

        for (int i = 0; i < m; i++)
        {
            int val = values[i];

            if (freq[val] * 2 > n)
                continue;

            if (counts[i] >= 2)
            {
                result.Add(val);
                continue;
            }

            if (i > 0 && i < m - 1 &&
                values[i - 1] == val &&
                counts[i] == 1)
            {
                result.Add(val);
            }
        }

        return new List<int>(result);
    }

}
