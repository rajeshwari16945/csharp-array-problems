using System;
using System.Collections.Generic;

public class ClusterCompressor
{
    public static int[] CompressClusters(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return Array.Empty<int>();

        List<int> result = new List<int>();

        int count = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
            }
            else
            {
                result.Add(nums[i - 1]);
                result.Add(count);
                count = 1; 
            }
        }

        result.Add(nums[nums.Length - 1]);
        result.Add(count);

        return result.ToArray();
    }
}
