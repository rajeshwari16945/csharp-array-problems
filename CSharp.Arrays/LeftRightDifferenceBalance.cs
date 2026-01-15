using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LeftRightDifferenceBalance
    {
        public static int MinBalanceIndex(int[] arr)
        {
            int n = arr.Length;

            int totalSum = 0;
            for (int i = 0; i < n; i++)
                totalSum += arr[i];

            int leftSum = 0;
            int minBalance = int.MaxValue;
            int resultIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int rightSum = totalSum - leftSum - arr[i];
                int balance = Math.Abs(leftSum - rightSum);

                if (balance < minBalance)
                {
                    minBalance = balance;
                    resultIndex = i;
                }

                leftSum += arr[i];
            }

            return resultIndex;
        }
    }
}
