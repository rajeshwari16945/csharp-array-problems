using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayTimeShiftInversions
    {
        public static int MaxTimeShiftInversions(int[] arr)
        {
            int n = arr.Length;
            var freq = new Dictionary<long, int>();
            int maxCount = 0;

            // Traverse from right to left
            for (int i = n - 1; i >= 0; i--)
            {
                long key = (long)arr[i] - i;

                if (freq.ContainsKey(key))
                {
                    maxCount = Math.Max(maxCount, freq[key]);
                    freq[key]++;
                }
                else
                {
                    freq[key] = 1;
                }
            }

            return maxCount;
        }
    }
}
