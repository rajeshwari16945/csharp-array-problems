using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LongestIncreasingAfterOneReverse
    {
        public static int reverse(int[] arr)
        {
            int maxLen = 1, curr = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                    curr++;
                else
                    curr = 1;

                maxLen = Math.Max(maxLen, curr);
            }
            return maxLen;
        }

        public static int Solve(int[] original)
        {
            int n = original.Length;
            int answer = reverse(original);

            for (int l = 0; l < n; l++)
            {
                for (int r = l + 1; r < n; r++)
                {
                    int[] arr = (int[])original.Clone(); 
                    Array.Reverse(arr, l, r - l + 1);
                    answer = Math.Max(answer, reverse(arr));
                }
            }
            return answer;
        }

    }
}
