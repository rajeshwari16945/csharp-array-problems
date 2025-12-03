using System;

class MaxSumSubmatrixLimitedDistinct
{
    public static void Find()
    {
        int[] arr = {
            1, 2, 1,
            2, 3, 4,
            1, 1, 5
        };
        int rows = 3;
        int cols = 3;
        int k = 3;

        int result = MaxSumSubmatrix(arr, rows, cols, k);
        Console.WriteLine("Max sum: " + result);
    }

    static int MaxSumSubmatrix(int[] arr, int rows, int cols, int k)
    {
        int[,] grid = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                grid[i, j] = arr[i * cols + j];

        int maxVal = int.MinValue;

        for (int top = 0; top < rows; top++)
        {
            for (int left = 0; left < cols; left++)
            {
                int[] freq = new int[1001]; 
                int distinctCount = 0;

                for (int bottom = top; bottom < rows; bottom++)
                {
                    int sum = 0;
                    int[] tempFreq = new int[1001];

                    for (int right = left; right < cols; right++)
                    {
                        for (int r = top; r <= bottom; r++)
                        {
                            int val = grid[r, right];
                            tempFreq[val]++;
                            if (tempFreq[val] == 1)
                                distinctCount++;
                        }

                        if (distinctCount <= k)
                        {
                            for (int r = top; r <= bottom; r++)
                                for (int c = left; c <= right; c++)
                                    sum += grid[r, c];

                            if (sum > maxVal)
                                maxVal = sum;
                        }

                        distinctCount = 0;
                    }
                }
            }
        }

        return maxVal;
    }
}
