using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayEntropyCompression
    {
        public static int MinEntropyAfterCompression(int[] arr)
        {
            int n = arr.Length;
            if (n <= 1) return 0;

            int originalEntropy = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    originalEntropy++;
            }

            int maxGain = 0;
            int iPtr = 0;

            while (iPtr < n)
            {
                int start = iPtr;
                int value = arr[iPtr];

                while (iPtr < n && arr[iPtr] == value)
                    iPtr++;

                int end = iPtr - 1;
                int length = end - start + 1;

                if (length > 1)
                {
                    int gain = length - 1;

                    if (start > 0 && arr[start - 1] == value)
                        gain--;

                    if (end < n - 1 && arr[end + 1] == value)
                        gain--;

                    if (gain > maxGain)
                        maxGain = gain;
                }
            }

            return originalEntropy - maxGain;
        }

    }
}
