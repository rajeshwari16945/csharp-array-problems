using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class CountBalancedIndices
    {
        public static int GetCount(int[] nums)
        {
            int n = nums.Length;

            int[] leftDist = new int[n];
            int[] rightDist = new int[n];

            var lastSeen = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (lastSeen.ContainsKey(nums[i]))
                    leftDist[i] = i - lastSeen[nums[i]];
                else
                    leftDist[i] = int.MaxValue;

                lastSeen[nums[i]] = i;
            }

            lastSeen.Clear();

            for (int i = n - 1; i >= 0; i--)
            {
                if (lastSeen.ContainsKey(nums[i]))
                    rightDist[i] = lastSeen[nums[i]] - i;
                else
                    rightDist[i] = int.MaxValue;

                lastSeen[nums[i]] = i;
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (leftDist[i] == rightDist[i])
                    count++;
            }

            return count;
        }
    }
}
