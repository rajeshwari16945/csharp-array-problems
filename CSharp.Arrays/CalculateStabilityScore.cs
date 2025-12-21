using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class CalculateStabilityScore
    {

        public static int GetCalculateStabilityScore(int[] arr)
        {
            if (arr == null || arr.Length < 3)
                return 0;

            int score = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    score += 2;
                }
                else if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                {
                    score += 1;
                }
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] && arr[i] == arr[i - 2])
                {
                    score -= 3;
                    break; 
                }
            }

            return score;
        }


    }
}
