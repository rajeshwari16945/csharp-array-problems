using System;
using System.Collections.Generic;

class CircularInfluence
{

    public static int[] CalculateInfluence(int[] arr)
    {
        int n = arr.Length;
        int[] rightDist = new int[n];
        int[] leftDist = new int[n];

        for (int i = 0; i < n; i++)
        {
            rightDist[i] = n;
            leftDist[i] = n;
        }

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < 2 * n; i++)
        {
            int idx = i % n;

            while (stack.Count > 0 && arr[stack.Peek()] < arr[idx])
            {
                int prev = stack.Pop();
                rightDist[prev] = (idx - prev + n) % n;
            }

            if (i < n)
                stack.Push(idx);
        }

        stack.Clear();

        for (int i = 2 * n - 1; i >= 0; i--)
        {
            int idx = i % n;

            while (stack.Count > 0 && arr[stack.Peek()] < arr[idx])
            {
                int prev = stack.Pop();
                leftDist[prev] = (prev - idx + n) % n;
            }

            if (i >= n)
                stack.Push(idx);
        }

        int[] influence = new int[n];
        for (int i = 0; i < n; i++)
        {
            influence[i] = rightDist[i] + leftDist[i];
        }

        return influence;
    }
}
