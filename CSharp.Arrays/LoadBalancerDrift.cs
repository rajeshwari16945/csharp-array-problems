using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LoadBalancerDrift
    {
        public static int MinLoadMoves(int[] load)
        {
            int n = load.Length;
            long total = 0;

            foreach (int x in load)
                total += x;

            if (total % n != 0)
                return -1;

            long target = total / n;
            long prefixImbalance = 0;
            long maxMoves = 0;

            for (int i = 0; i < n; i++)
            {
                prefixImbalance += load[i] - target;
                maxMoves = Math.Max(maxMoves, Math.Abs(prefixImbalance));
            }

            return (int)maxMoves;
        }

    }
}
