using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MinimumSegmentSplitCost
    {
        public static int MinSplitCost(int[] arr)
        {
            int n = arr.Length;
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
            {
                int maxVal = 0;
                dp[i] = int.MaxValue;

                for (int j = i; j >= 0; j--)
                {
                    maxVal = Math.Max(maxVal, arr[j]);
                    int cost = maxVal * (i - j + 1);

                    int prev = (j > 0) ? dp[j - 1] : 0;
                    dp[i] = Math.Min(dp[i], prev + cost);
                }
            }

            return dp[n - 1];
        }

    }
}
