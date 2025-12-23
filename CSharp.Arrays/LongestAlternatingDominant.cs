using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LongestAlternatingDominant
    {
        public static int GetLongestAlternatingDominant(int[] arr)
        {
            int n = arr.Length;
            if (n < 3) return 0;

            int maxLen = 0;
            int start = 0;

            for (int i = 1; i < n; i++)
            {
                bool alternating = (long)arr[i] * arr[i - 1] < 0;

                if (!alternating)
                {
                    start = i;
                    continue;
                }

                if (i >= 2)
                {
                    if (Math.Abs(arr[i - 1]) <= Math.Abs(arr[i - 2]) ||
                        Math.Abs(arr[i - 1]) <= Math.Abs(arr[i]))
                    {
                        start = i - 1;
                    }
                }

                int length = i - start + 1;
                if (length >= 3)
                    maxLen = Math.Max(maxLen, length);
            }

            return maxLen;
        }
    }
}
