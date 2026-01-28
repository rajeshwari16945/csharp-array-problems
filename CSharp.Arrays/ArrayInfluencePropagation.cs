using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayInfluencePropagation
    {
        public static int[] ApplyInfluence(int[] arr)
        {
            int n = arr.Length;
            int[] diff = new int[n];

            for (int i = 0; i < n; i++)
            {
                int value = arr[i];
                if (value == 0) continue;

                if (value > 0)
                {
                    for (int j = i + 1; j <= i + value && j < n; j++)
                    {
                        if (arr[j] == 0)
                            diff[j] += value;
                    }
                }
                else
                {
                    for (int j = i - 1; j >= i + value && j >= 0; j--)
                    {
                        if (arr[j] == 0)
                            diff[j] += value;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] += diff[i];
            }

            return arr;
        }
    }
}
