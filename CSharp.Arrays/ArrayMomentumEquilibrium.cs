using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayMomentumEquilibrium
    {
        public static List<int> MomentumEquilibriumIndices(int[] arr)
        {
            int n = arr.Length;
            var result = new List<int>();

            long totalSum = 0;
            long totalWeightedSum = 0;

            for (int i = 0; i < n; i++)
            {
                totalSum += arr[i];
                totalWeightedSum += (long)arr[i] * i;
            }

            long leftSum = 0;
            long leftWeightedSum = 0;

            for (int i = 0; i < n; i++)
            {
                long rightSum = totalSum - leftSum - arr[i];
                long rightWeightedSum = totalWeightedSum - leftWeightedSum - (long)arr[i] * i;

                long leftMomentum = (long)i * leftSum - leftWeightedSum;
                long rightMomentum = rightWeightedSum - (long)i * rightSum;

                if (leftMomentum == rightMomentum)
                    result.Add(i);

                leftSum += arr[i];
                leftWeightedSum += (long)arr[i] * i;
            }

            return result;
        }
    }
}
