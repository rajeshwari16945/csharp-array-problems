using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ParityInfluenceRadius
    {
        public static int[] get(int[] arr)
        {
            int n = arr.Length;
            int[] a = new int[n + 1];
            for (int i = 0; i < n; i++)
                a[i + 1] = a[i] + ((arr[i] & 1) == 0 ? 1 : -1);

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                int lo = 0, hi = Math.Min(i, n - i - 1);
                while (lo <= hi)
                {
                    int mid = (lo + hi) / 2;
                    int sum = a[i + mid + 1] - a[i - mid];
                    if (sum > 0)
                    {
                        res[i] = mid;
                        lo = mid + 1;
                    }
                    else hi = mid - 1;
                }
            }
            return res;
        }
    }
}
