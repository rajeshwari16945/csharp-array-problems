using System;

class PeakInWaveArray
{

    public static int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // If mid is less than its next element, the peak is on the right side
            if (nums[mid] < nums[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                // Otherwise, the peak is on the left side (including mid)
                right = mid;
            }
        }

        // left == right is the index of a peak
        return left;
    }
}
