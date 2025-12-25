using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class AlternatingMajorityPrefix
    {

        public static int Get(int[] arr)
        {
            var freq = new Dictionary<int, int>();

            int? candidate = null;
            int count = 0;

            int? prevDominant = null;
            int changes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];

                if (count == 0)
                {
                    candidate = x;
                    count = 1;
                }
                else if (candidate == x)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                // Update real frequency
                if (!freq.ContainsKey(x))
                    freq[x] = 0;
                freq[x]++;

                // Check if candidate is actually dominant
                int? currDominant = null;
                if (candidate.HasValue && freq[candidate.Value] > (i + 1) / 2)
                {
                    currDominant = candidate.Value;
                }

                // Count dominant changes
                if (currDominant.HasValue && currDominant != prevDominant)
                {
                    changes++;
                }

                prevDominant = currDominant;
            }

            return changes;
        }

    }
}
