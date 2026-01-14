using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StableDisruptionIndex
    {
        public int CountDisruptionIndices(int[] nums)
        {
            int n = nums.Length;
            if (n <= 2) return n; 

            bool[] incPref = new bool[n];
            bool[] incSuff = new bool[n];
            bool[] decPref = new bool[n];
            bool[] decSuff = new bool[n];

            incPref[0] = true;
            for (int i = 1; i < n; i++)
                incPref[i] = incPref[i - 1] && nums[i] > nums[i - 1];

            incSuff[n - 1] = true;
            for (int i = n - 2; i >= 0; i--)
                incSuff[i] = incSuff[i + 1] && nums[i] < nums[i + 1];

            decPref[0] = true;
            for (int i = 1; i < n; i++)
                decPref[i] = decPref[i - 1] && nums[i] < nums[i - 1];

            decSuff[n - 1] = true;
            for (int i = n - 2; i >= 0; i--)
                decSuff[i] = decSuff[i + 1] && nums[i] > nums[i + 1];

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                bool incValid = true;
                bool decValid = true;

                if (i > 0 && !incPref[i - 1]) incValid = false;
                if (i < n - 1 && !incSuff[i + 1]) incValid = false;
                if (i > 0 && i < n - 1 && nums[i - 1] >= nums[i + 1])
                    incValid = false;

                if (i > 0 && !decPref[i - 1]) decValid = false;
                if (i < n - 1 && !decSuff[i + 1]) decValid = false;
                if (i > 0 && i < n - 1 && nums[i - 1] <= nums[i + 1])
                    decValid = false;

                if (incValid || decValid)
                    count++;
            }

            return count;
        }
    }
}
