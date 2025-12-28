using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MaxGravityEnergy
    {
        public static int GetMaxGravityEnergy(int[] a)
        {
            int n = a.Length, ans = 0;
            int[] L = new int[n], R = new int[n];

            for (int i = 0; i < n; i++) L[i] = i;
            for (int i = n - 1; i >= 0; i--) R[i] = i;

            for (int i = 1; i < n; i++)
                if (a[i] < a[i - 1]) L[i] = L[i - 1];

            for (int i = n - 2; i >= 0; i--)
                if (a[i] < a[i + 1]) R[i] = R[i + 1];

            for (int i = 1; i < n - 1; i++)
                if (a[i] < a[i - 1] && a[i] < a[i + 1])
                {
                    int sum = 0;
                    for (int j = L[i]; j <= R[i]; j++) sum += a[j];
                    int depth = Math.Min(a[L[i]], a[R[i]]) - a[i];
                    ans = Math.Max(ans, sum * depth);
                }

            return ans;
        }

    }
}
