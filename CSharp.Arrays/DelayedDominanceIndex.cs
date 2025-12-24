using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DelayedDominanceIndex
    {
        public static int[] GetDelayedDominanceIndex(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];
            Array.Fill(result, -1);

            Stack<int> stack = new Stack<int>(); // stores indices

            for (int i = 0; i < n; i++)
            {
                // Resolve delayed dominance
                while (stack.Count > 0 && arr[i] > arr[stack.Peek()])
                {
                    int idx = stack.Pop();
                    result[idx] = i - idx;
                }

                stack.Push(i);
            }

            return result;
        }
    }
}
