using System;

public class UniqueSubarraySumMinCost
{
    public static long MinCost(int[] nums)
    {
        int n = nums.Length;
        long[] prefix = new long[n + 1];
        for (int i = 0; i < n; i++) prefix[i + 1] = prefix[i] + nums[i];

        long[] diff = new long[n];
        for (int i = 0; i < n; i++) diff[i] = prefix[i + 1] - prefix[i];

        long cost = 0;
        for (int i = 1; i < n; i++)
        {
            if (diff[i] <= diff[i - 1])
            {
                long target = diff[i - 1] + 1;
                cost += Math.Abs(target - diff[i]);
                diff[i] = target;
            }
        }

        long[] newPrefix = new long[n + 1];
        for (int i = 1; i <= n; i++) newPrefix[i] = newPrefix[i - 1] + diff[i - 1];

        return cost;
    }
}
