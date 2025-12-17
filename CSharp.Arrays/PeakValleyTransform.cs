using System;

class PeakValleyTransform
{

    public static void GetPeakValleyTransform(int[] arr)
    {
        for (int i = 1; i < arr.Length; i += 2)
        {
            if (arr[i] < arr[i - 1])
            {
                Swap(arr, i, i - 1);
            }
            if (i + 1 < arr.Length && arr[i] < arr[i + 1])
            {
                Swap(arr, i, i + 1);
            }
        }
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
