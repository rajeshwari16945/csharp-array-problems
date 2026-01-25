using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class InvisibleMajorityWindows
    {
        public static long InvisibleMajority(int[] arr)
        {
            int n = arr.Length;

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int x in arr)
            {
                if (!freq.ContainsKey(x))
                    freq[x] = 0;
                freq[x]++;
            }
            int globalMajority = -1;
            int maxFreq = 0;
            foreach (var kv in freq)
            {
                if (kv.Value > maxFreq)
                {
                    maxFreq = kv.Value;
                    globalMajority = kv.Key;
                }
            }

            long result = 0;

            foreach (int x in freq.Keys)
            {
                if (x == globalMajority)
                    continue;

                int prefix = 0;
                List<int> sortedPrefixes = new List<int> { 0 };

                foreach (int val in arr)
                {
                    if (val == x)
                        prefix += 1;
                    else
                        prefix -= 1;

                    int count = LowerBound(sortedPrefixes, prefix);
                    result += count;

                    sortedPrefixes.Insert(count, prefix);
                }
            }

            return result;
        }

        private static int LowerBound(List<int> list, int target)
        {
            int left = 0, right = list.Count;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] < target)
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
