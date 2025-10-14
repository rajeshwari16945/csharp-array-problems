using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LongestSubArray
    {
        public void getLongestSubArray()
        {
            Console.WriteLine("Enter array elements separated by space:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Enter the target sum (K): ");
            int k = int.Parse(Console.ReadLine());

            int left = 0, right = 0;
            int sum = 0, maxLength = 0;

            while (right < arr.Length)
            {
                sum += arr[right];

                while (sum > k && left <= right)
                {
                    sum -= arr[left];
                    left++;
                }

                if (sum == k)
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                }

                right++;
            }

            Console.WriteLine($"Length of the longest subarray with sum {k}: {maxLength}");

        }
    }
}
