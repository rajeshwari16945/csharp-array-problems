public class CircularNextGreaterElement
{
    public static int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);

        Stack<int> stack = new Stack<int>(); 

        for (int i = 0; i < n * 2; i++)
        {
            int num = nums[i % n];

            while (stack.Count > 0 && nums[stack.Peek()] < num)
            {
                int index = stack.Pop();
                result[index] = num;
            }

            if (i < n)
                stack.Push(i);
        }

        return result;
    }
}
