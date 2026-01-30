using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArraySelfDestructionOrder
    {
        public static bool CanSelfDestruct(int[] arr)
        {
            long totalSum = 0;
            int max = 0;

            foreach (int x in arr)
            {
                totalSum += x;
                if (x > max)
                    max = x;
            }

            if (arr.Length == 1)
                return arr[0] == 0;

            return max <= totalSum - max;
        }
    }
}
