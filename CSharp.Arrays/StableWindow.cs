using System;

class StableWindow
{
    public static int LongestStableWindow(int[] signal)
    {
        int n = signal.Length;
        if (n < 3) return 0;

        int[] decLeft = new int[n];
        int[] incRight = new int[n];

        decLeft[0] = 1;
        for (int i = 1; i < n; i++)
        {
            if (signal[i] < signal[i - 1])
                decLeft[i] = decLeft[i - 1] + 1;
            else
                decLeft[i] = 1;
        }

        incRight[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (signal[i] < signal[i + 1])
                incRight[i] = incRight[i + 1] + 1;
            else
                incRight[i] = 1;
        }

        int maxLen = 0;

        for (int i = 1; i < n - 1; i++)
        {
            if (decLeft[i] > 1 && incRight[i] > 1)
            {
                int length = decLeft[i] + incRight[i] - 1;
                maxLen = Math.Max(maxLen, length);
            }
        }

        return maxLen >= 3 ? maxLen : 0;
    }

}
