using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LongestSubarraywithEqual0sand1s
    {
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> sumIndexMap = new Dictionary<int, int>();

            int maxLength = 0;
            int sum = 0;

            sumIndexMap[0] = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += (nums[i] == 0) ? -1 : 1;

                if (sumIndexMap.ContainsKey(sum))
                {
                    maxLength = Math.Max(maxLength, i - sumIndexMap[sum]);
                }
                else
                {
                    sumIndexMap[sum] = i;
                }
            }

            return maxLength;
        }
    }
}
