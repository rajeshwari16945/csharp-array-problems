using System;

public class WaveTransformer
{
    public static void ToWave(int[] nums)
    {
        if (nums == null || nums.Length < 2)
            return;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                if (nums[i] > nums[i + 1])
                {
                    Swap(nums, i, i + 1);
                }
            }
            else
            {
                if (nums[i] < nums[i + 1])
                {
                    Swap(nums, i, i + 1);
                }
            }
        }
    }

    private static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    
}
