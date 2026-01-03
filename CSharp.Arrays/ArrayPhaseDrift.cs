using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayPhaseDrift
    {
        public static int[] PhaseDrift(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];

            int[] sorted = (int[])arr.Clone();
            Array.Sort(sorted);

            Dictionary<int, int> rank = new Dictionary<int, int>();
            int r = 1;
            foreach (int v in sorted)
                if (!rank.ContainsKey(v))
                    rank[v] = r++;

            Fenwick fenwick = new Fenwick(r + 2);

            for (int i = n - 1; i >= 0; i--)
            {
                int currentRank = rank[arr[i]];

                result[i] = fenwick.Query(currentRank - 1);

                fenwick.Update(currentRank, 1);
            }

            return result;
        }

        class Fenwick
        {
            private int[] tree;

            public Fenwick(int size)
            {
                tree = new int[size];
            }

            public void Update(int index, int delta)
            {
                while (index < tree.Length)
                {
                    tree[index] += delta;
                    index += index & -index;
                }
            }

            public int Query(int index)
            {
                int sum = 0;
                while (index > 0)
                {
                    sum += tree[index];
                    index -= index & -index;
                }
                return sum;
            }
        }
    }
}
