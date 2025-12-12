using System;
using System.Collections.Generic;

public class ArrayTransformer
{
    public int[] SegmentedAlternatingSums(int[] nums, int k)
    {
        List<int> result = new List<int>();
        int n = nums.Length;

        for (int start = 0; start < n; start += k)
        {
            int end = Math.Min(start + k, n);
            int segmentIndex = start / k;
            int sum = 0;

            if (segmentIndex % 2 == 0)
            {
                bool add = true;
                for (int i = start; i < end; i++)
                {
                    sum += add ? nums[i] : -nums[i];
                    add = !add;
                }
            }
            else
            {
                bool add = true;
                for (int i = end - 1; i >= start; i--)
                {
                    sum += add ? nums[i] : -nums[i];
                    add = !add;
                }
            }

            result.Add(sum);
        }

        return result.ToArray();
    }
}
