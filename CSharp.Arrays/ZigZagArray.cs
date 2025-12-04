using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ZigZagArray
    {
        public static int MovesToMakeZigzag(int[] nums)
        {
            return Math.Min(Calc(nums, 0), Calc(nums, 1));
        }

        private static int Calc(int[] nums, int startLow)
        {
            int n = nums.Length;
            int moves = 0;

            for (int i = 0; i < n; i++)
            {
                // Determine if this position should be a "valley"
                bool shouldBeLow = (i % 2 == startLow);

                if (shouldBeLow)
                {
                    int target = int.MaxValue;

                    if (i - 1 >= 0) target = Math.Min(target, nums[i - 1]);
                    if (i + 1 < n) target = Math.Min(target, nums[i + 1]);

                    if (target == int.MaxValue) continue; // no neighbors (single element)

                    if (nums[i] >= target)
                        moves += nums[i] - (target - 1);
                }
            }

            return moves;
        }

    }
}
