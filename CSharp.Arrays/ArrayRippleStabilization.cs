using System;

class ArrayRippleStabilization
{
    public static bool CanStabilize(int[] arr)
    {
        int n = arr.Length;

        if (n <= 2)
            return true;

        int conflicts = 0;

        for (int i = 1; i < n - 1; i++)
        {
            if (arr[i] == arr[i - 1] || arr[i] == arr[i + 1])
            {
                conflicts++;

                if (conflicts > 1)
                    return false;
            }
        }

        return true;
    }
}
