using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class RecovertheHiddenPermutation
    {
        public static int[] RecoverPermutation(int[] a)
        {
            int n = a.Length;
            int[] result = new int[n];

            for (int i = 1; i < n; i++)
            {
                if (a[i] < a[i - 1])
                    return Array.Empty<int>();
            }

            bool[] used = new bool[n + 1];

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            int prevMax = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > prevMax)
                {
                    if (a[i] < 1 || a[i] > n || used[a[i]])
                        return Array.Empty<int>();

                    result[i] = a[i];
                    used[a[i]] = true;

                    for (int x = prevMax + 1; x < a[i]; x++)
                    {
                        if (!used[x])
                            pq.Enqueue(x, -x); 
                    }

                    prevMax = a[i];
                }
                else
                {
                    if (pq.Count == 0)
                        return Array.Empty<int>();

                    result[i] = pq.Dequeue();
                }
            }

            return result;
        }
    }
}
