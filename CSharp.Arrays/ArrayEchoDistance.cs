using System;
using System.Collections.Generic;

class ArrayEchoDistance
{

    public static int[] GetArrayEchoDistance(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);

        Dictionary<int, int> lastIndex = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (lastIndex.ContainsKey(nums[i]))
            {
                int prev = lastIndex[nums[i]];
                int distance = i - prev;
                result[i] = distance;
                if (result[prev] == -1 || distance < result[prev])
                {
                    result[prev] = distance;
                }
            }
            lastIndex[nums[i]] = i;
        }

        return result;
    }
}
