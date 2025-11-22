using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class UnSortedSubArray
    {
        public void FindUnSortedSubArray()
        {
            int[] nums = {2, 6, 4, 8, 10, 9, 15};
            int n = nums.Length;
            int left = -1;
            int right = -1;

            int maxSeen = int.MinValue;
            int minSeen = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                maxSeen = Math.Max(maxSeen, nums[i]);
                if (nums[i] < maxSeen)
                    right = i;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                minSeen = Math.Min(minSeen, nums[i]);
                if (nums[i] > minSeen)
                    left = i;
            }

            if (left == -1) Console.WriteLine(0);

            Console.WriteLine( right - left + 1);
        }
    }
}
