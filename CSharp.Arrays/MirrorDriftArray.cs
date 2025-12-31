using System;

class MirrorDriftArray
{
    public static int[] DriftOnce(int[] arr)
    {
        int n = arr.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int value = arr[i];
            int mirror = n - 1 - i;

            int newIndex = i;

            if (value % 2 == 0) 
            {
                if (i < mirror)
                    newIndex = i + 1;
                else if (i > mirror)
                    newIndex = i - 1;
            }
            else 
            {
                if (i < mirror)
                    newIndex = i - 1;
                else if (i > mirror)
                    newIndex = i + 1;
            }

            if (newIndex < 0)
                newIndex = n - 1;
            else if (newIndex >= n)
                newIndex = 0;

            result[newIndex] += value;
        }

        return result;
    }

}
