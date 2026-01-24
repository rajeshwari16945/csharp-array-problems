using System;
using System.Collections.Generic;

public class ConditionalRewind
{
    public static List<int> ApplyConditionalRewind(int[] ops)
    {
        List<int> result = new List<int>();

        Stack<int> checkpoints = new Stack<int>();

        foreach (int op in ops)
        {
            if (op > 0)
            {
                result.Add(op);
            }
            else if (op == 0)
            {
                checkpoints.Push(result.Count);
                result.Add(0);
            }
            else 
            {
                int k = -op;

                int boundary = checkpoints.Count > 0 ? checkpoints.Peek() + 1 : 0;

                while (k > 0 && result.Count > boundary)
                {
                    result.RemoveAt(result.Count - 1);
                    k--;
                }
            }
        }

        return result;
    }
}
