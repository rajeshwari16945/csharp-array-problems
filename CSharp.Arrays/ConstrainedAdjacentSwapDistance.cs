using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ConstrainedAdjacentSwapDistance
    {
        public long MinSwapsWithDependencies(int[] A, int[] B, List<(int x, int y)> deps)
        {
            int n = A.Length;

            var graph = new Dictionary<int, List<int>>();
            var indeg = new Dictionary<int, int>();

            foreach (var v in A)
            {
                graph[v] = new List<int>();
                indeg[v] = 0;
            }

            foreach (var (x, y) in deps)
            {
                graph[y].Add(x);
                indeg[x]++;
            }

            var topo = TopologicalSort(graph, indeg);
            if (topo == null)
                return -1;

            var posB = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
                posB[B[i]] = i;

            foreach (var (x, y) in deps)
                if (posB[x] < posB[y])
                    return -1;

            int[] targetIndex = new int[n];
            var currentPositions = new Dictionary<int, Queue<int>>();

            for (int i = 0; i < n; i++)
            {
                int v = B[i];
                if (!currentPositions.ContainsKey(v))
                    currentPositions[v] = new Queue<int>();
                currentPositions[v].Enqueue(i);
            }

            for (int i = 0; i < n; i++)
            {
                int v = A[i];
                targetIndex[i] = currentPositions[v].Dequeue();
            }

            var bit = new Fenwick(n);
            long swaps = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                swaps += bit.Sum(targetIndex[i]);
                bit.Add(targetIndex[i], 1);
            }

            return swaps;
        }

        private List<int> TopologicalSort(Dictionary<int, List<int>> graph, Dictionary<int, int> indeg)
        {
            var q = new Queue<int>();
            foreach (var kv in indeg)
                if (kv.Value == 0)
                    q.Enqueue(kv.Key);

            var result = new List<int>();

            while (q.Count > 0)
            {
                int v = q.Dequeue();
                result.Add(v);

                foreach (int nxt in graph[v])
                {
                    indeg[nxt]--;
                    if (indeg[nxt] == 0)
                        q.Enqueue(nxt);
                }
            }

            if (result.Count != graph.Count)
                return null;

            return result;
        }

        public class Fenwick
        {
            private long[] bit;
            private int n;

            public Fenwick(int size)
            {
                n = size + 1;
                bit = new long[n];
            }

            public void Add(int index, long val)
            {
                for (int i = index + 1; i < n; i += i & -i)
                    bit[i] += val;
            }

            public long Sum(int index)
            {
                long s = 0;
                for (int i = index + 1; i > 0; i -= i & -i)
                    s += bit[i];
                return s;
            }
        }
    }
}
