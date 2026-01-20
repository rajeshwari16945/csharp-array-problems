using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class PalindromeInfluenceSpan
    {
        public static int[] GetInfluenceArr(string[] arr)
        {
            int n = arr.Length;

            string[] t = new string[2 * n + 1];
            for (int i = 0; i < n; i++)
            {
                t[2 * i] = "#";
                t[2 * i + 1] = arr[i];
            }
            t[2 * n] = "#";

            int m = t.Length;
            int[] p = new int[m];
            int center = 0, right = 0;

            for (int i = 0; i < m; i++)
            {
                int mirror = 2 * center - i;
                if (i < right)
                    p[i] = Math.Min(right - i, p[mirror]);

                while (i + p[i] + 1 < m && i - p[i] - 1 >= 0 && t[i + p[i] + 1] == t[i - p[i] - 1])
                    p[i]++;

                if (i + p[i] > right)
                {
                    center = i;
                    right = i + p[i];
                }
            }

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int pos = 2 * i + 1; 
                int radius = p[pos]; 
                result[i] = radius; 
                result[i] = radius / 2 * 2 + 1; 
            }

            return result;
        }
    }
}
