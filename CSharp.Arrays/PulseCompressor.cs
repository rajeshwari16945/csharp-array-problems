using System;
using System.Collections.Generic;

public class PulseCompressor
{
    public static int[] CompressPulses(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return Array.Empty<int>();

        List<int> result = new List<int>();

        int currentSum = 0;
        int previousSign = 0;

        foreach (int value in arr)
        {
            if (value == 0)
            {
                if (currentSum > 0)
                {
                    result.Add(currentSum);
                    currentSum = 0;
                }
                previousSign = 0;
                continue;
            }

            int currentSign = value > 0 ? 1 : -1;

            if (previousSign != 0 && currentSign == previousSign)
            {
                result.Add(currentSum);
                currentSum = 0;
            }

            currentSum += Math.Abs(value);
            previousSign = currentSign;
        }

        if (currentSum > 0)
            result.Add(currentSum);

        return result.ToArray();
    }

}
