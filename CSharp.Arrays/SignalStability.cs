using System;
using System.Collections.Generic;

class SignalStability
{
    public static int CountStableWindows(int[] signals, int k, int t)
    {
        if (signals == null || signals.Length == 0 || k > signals.Length)
            return 0;

        LinkedList<int> minDeque = new LinkedList<int>(); 
        LinkedList<int> maxDeque = new LinkedList<int>(); 

        int stableCount = 0;

        for (int i = 0; i < signals.Length; i++)
        {
            if (minDeque.Count > 0 && minDeque.First.Value <= i - k)
                minDeque.RemoveFirst();

            if (maxDeque.Count > 0 && maxDeque.First.Value <= i - k)
                maxDeque.RemoveFirst();

            while (minDeque.Count > 0 && signals[minDeque.Last.Value] >= signals[i])
                minDeque.RemoveLast();

            while (maxDeque.Count > 0 && signals[maxDeque.Last.Value] <= signals[i])
                maxDeque.RemoveLast();

            minDeque.AddLast(i);
            maxDeque.AddLast(i);

            if (i >= k - 1)
            {
                int minVal = signals[minDeque.First.Value];
                int maxVal = signals[maxDeque.First.Value];

                if (maxVal - minVal <= t)
                    stableCount++;
            }
        }

        return stableCount;
    }

}
