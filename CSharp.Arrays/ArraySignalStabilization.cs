using System;

class ArraySignalStabilization
{
    public static int MinRemovalsForStability(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2) return 0;

        int[,] dp = new int[n, 2];

        for (int i = 0; i < n; i++)
        {
            dp[i, 0] = dp[i, 1] = 1;
        }

        int maxLen = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] >= nums[j])
                {
                    dp[i, 1] = Math.Max(dp[i, 1], dp[j, 0] + 1);
                }
                if (nums[i] <= nums[j])
                {
                    dp[i, 0] = Math.Max(dp[i, 0], dp[j, 1] + 1);
                }
            }
            maxLen = Math.Max(maxLen, Math.Max(dp[i, 0], dp[i, 1]));
        }

        return n - maxLen;
    }

}
