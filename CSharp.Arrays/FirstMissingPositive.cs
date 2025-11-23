using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class FirstMissingPositive
    {
        public static int Find(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    int correctIndex = nums[i] - 1;
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return n + 1;
        }
    }

}
