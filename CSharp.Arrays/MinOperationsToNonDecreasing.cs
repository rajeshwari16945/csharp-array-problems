using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MinOperationsToNonDecreasing
    {
        public static int Get(int[] arr)
        {
            int n = arr.Length;
            int ops = 0;

            int limit = arr[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] <= limit)
                {
                    limit = arr[i];
                }
                else
                {
                    ops++;
                }
            }

            return ops;
        }
    }
}
