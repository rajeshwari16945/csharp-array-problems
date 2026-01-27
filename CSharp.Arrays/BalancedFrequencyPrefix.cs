using System;
using System.Collections.Generic;

class BalancedFrequencyPrefix
{
    public static int CountBalancedPrefixes(int[] arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        Dictionary<int, int> freqCount = new Dictionary<int, int>();

        int balancedCount = 0;

        foreach (int num in arr)
        {
            int oldFreq = freq.ContainsKey(num) ? freq[num] : 0;

            if (oldFreq > 0)
            {
                freqCount[oldFreq]--;
                if (freqCount[oldFreq] == 0)
                    freqCount.Remove(oldFreq);
            }

            int newFreq = oldFreq + 1;
            freq[num] = newFreq;

            if (!freqCount.ContainsKey(newFreq))
                freqCount[newFreq] = 0;
            freqCount[newFreq]++;

            if (freqCount.Count == 1)
                balancedCount++;
        }

        return balancedCount;
    }

}
