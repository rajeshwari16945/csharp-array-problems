public class MaxSumTwoNoOverlap
{
    public static int GetMaxSumTwoNoOverlap(int[] nums, int k)
    {
        int n = nums.Length;

        int sumK = 0;
        for (int i = 0; i < k; i++)
        {
            sumK += nums[i];
        }

        int[] leftMax = new int[n];
        int[] rightMax = new int[n];

        leftMax[k - 1] = sumK;
        for (int i = k; i < n; i++)
        {
            sumK += nums[i] - nums[i - k];
            leftMax[i] = Math.Max(leftMax[i - 1], sumK);
        }

        sumK = 0;
        for (int i = n - 1; i >= n - k; i--)
        {
            sumK += nums[i];
        }
        rightMax[n - k] = sumK;
        for (int i = n - k - 1; i >= 0; i--)
        {
            sumK += nums[i] - nums[i + k];
            rightMax[i] = Math.Max(rightMax[i + 1], sumK);
        }

        int result = 0;
        for (int i = k - 1; i < n - k; i++)
        {
            result = Math.Max(result, leftMax[i] + rightMax[i + 1]);
        }

        return result;
    }
}
