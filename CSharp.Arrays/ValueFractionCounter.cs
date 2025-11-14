using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ValueFractionCounter
    {
        public static void CountValueFractions()
        {
            int[] arr = { -4, 3, -9, 0, 4, 1 };
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            int totalCount = arr.Length;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positiveCount++;
                }
                else if (num < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("Positive fraction: " + ((double)positiveCount / totalCount).ToString("F6"));
            Console.WriteLine("Negative fraction: " + ((double)negativeCount / totalCount).ToString("F6"));
            Console.WriteLine("Zero fraction: " + ((double)zeroCount / totalCount).ToString("F6"));
        }
    }
}
