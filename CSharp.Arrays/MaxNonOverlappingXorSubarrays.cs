using System;
using System.Collections.Generic;

class MaxNonOverlappingXorSubarrays
{
    public static int MaxNonOverlapping(int[] nums, int target)
    {
        int prefixXor = 0;
        int count = 0;

        HashSet<int> seen = new HashSet<int>();
        seen.Add(0); 

        foreach (int num in nums)
        {
            prefixXor ^= num;

            if (seen.Contains(prefixXor ^ target))
            {
                count++;

                seen.Clear();
                seen.Add(0);
                prefixXor = 0;
            }
            else
            {
                seen.Add(prefixXor);
            }
        }

        return count;
    }
}
