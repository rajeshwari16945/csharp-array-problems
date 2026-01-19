using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SilentMajoritySegments
    {
        public static long CountSilentMajority(int[] nums)
        {
            int n = nums.Length;
            var positions = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                if (!positions.ContainsKey(nums[i]))
                    positions[nums[i]] = new List<int>();
                positions[nums[i]].Add(i);
            }

            long result = 0;

            foreach (var kv in positions)
            {
                var pos = kv.Value;
                int k = pos.Count;

                if (k < 2) continue;

                int left = pos[0];
                int right = pos[k - 1];

                int len = right - left + 1;
                int[] prefix = new int[len + 1];

                for (int i = 0; i < len; i++)
                {
                    prefix[i + 1] = prefix[i] + (nums[left + i] == kv.Key ? 1 : -1);
                }

                var all = new List<int>(prefix);
                all.Sort();
                var index = new Dictionary<int, int>();
                for (int i = 0; i < all.Count; i++)
                    if (!index.ContainsKey(all[i]))
                        index[all[i]] = index.Count + 1;

                Fenwick fw = new Fenwick(index.Count);

                foreach (int p in prefix)
                {
                    int id = index[p];
                    result += fw.Query(id - 1);
                    fw.Update(id, 1);
                }
            }

            return result;
        }

        class Fenwick
        {
            private long[] tree;

            public Fenwick(int n)
            {
                tree = new long[n + 1];
            }

            public void Update(int i, long delta)
            {
                while (i < tree.Length)
                {
                    tree[i] += delta;
                    i += i & -i;
                }
            }

            public long Query(int i)
            {
                long sum = 0;
                while (i > 0)
                {
                    sum += tree[i];
                    i -= i & -i;
                }
                return sum;
            }
        }
    }
}
