using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MinMaxPartialSum
    {
        public static void getMinMax()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int totalSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }

            int minSum = int.MaxValue;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int sumOfFour = totalSum - arr[i];

                if (sumOfFour < minSum)
                    minSum = sumOfFour;

                if (sumOfFour > maxSum)
                    maxSum = sumOfFour;
            }

            Console.WriteLine("Minimum sum of 4 elements: " + minSum);
            Console.WriteLine("Maximum sum of 4 elements: " + maxSum);
        }
    }
}
