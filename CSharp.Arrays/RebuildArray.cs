using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class RebuildArray
    {
        public static int[] build(int[] visible)
        {
            int n = visible.Length;
            int[] arr = new int[n];
            List<int> right = new List<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                if (visible[i] > right.Count)
                    return Array.Empty<int>();

                int value = right.Count - visible[i];
                arr[i] = value;

                int pos = right.BinarySearch(value);
                if (pos < 0) pos = ~pos;
                right.Insert(pos, value);
            }

            return arr;
        }
    }
}
