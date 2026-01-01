using System;

public class StableDifferenceArray
{
    public static bool CanBeStable(int[] arr)
    {
        int n = arr.Length;
        if (n <= 2) return true;

        int? expectedDiff = null;
        int violations = 0;

        for (int i = 0; i < n - 1; i++)
        {
            int diff = arr[i + 1] - arr[i];
            if (diff == 0) continue;

            if (expectedDiff == null)
            {
                expectedDiff = diff;
            }
            else if (diff != expectedDiff)
            {
                violations++;

                if (violations > 1)
                    return false;

                if (i > 0 &&
                    arr[i + 1] - arr[i - 1] == expectedDiff)
                    continue;

                if (i + 2 < n &&
                    arr[i + 2] - arr[i] == expectedDiff)
                    continue;

                return false;
            }
        }

        return true;
    }
}
