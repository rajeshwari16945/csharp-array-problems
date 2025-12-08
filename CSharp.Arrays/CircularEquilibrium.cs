using System;
using System.Collections.Generic;

public class CircularEquilibrium
{
    public List<int> FindCircularEquilibriumPoints(int[] nums)
    {
        int n = nums.Length;
        List<int> result = new List<int>();

        if (n < 2)
            return result;

        int[] prefix = new int[2 * n + 1];
        for (int i = 0; i < 2 * n; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i % n];
        }

        int GetCircularSum(int start, int length)
        {
            int end = start + length;
            return prefix[end] - prefix[start];
        }

        for (int i = 0; i < n; i++)
        {
            bool isEquilibrium = false;

            for (int k = 1; k < n; k++)
            {
                int clockwiseStart = (i + 1) % n;
                int counterStart = (i - k + n) % n;

                int clockwiseSum = GetCircularSum(clockwiseStart, k);
                int counterSum = GetCircularSum(counterStart, k);

                if (clockwiseSum == counterSum)
                {
                    isEquilibrium = true;
                    break;
                }
            }

            if (isEquilibrium)
                result.Add(i);
        }

        return result;
    }
}
