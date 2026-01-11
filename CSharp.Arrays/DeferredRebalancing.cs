using System;
using System.Collections.Generic;

public class DeferredRebalancing
{
    public static int CountValidReconciliations(int[] events)
    {
        Stack<int> positiveStack = new Stack<int>(); 
        Queue<int> zeroQueue = new Queue<int>();     
        int validCount = 0;

        foreach (int e in events)
        {
            if (e > 0)
            {
                positiveStack.Push(e);
            }
            else if (e == 0)
            {
                zeroQueue.Enqueue(0);
            }
            else 
            {
                if (zeroQueue.Count > 0 && positiveStack.Count > 0)
                {
                    zeroQueue.Dequeue();
                    positiveStack.Pop();
                    validCount++;
                }
            }
        }

        return validCount;
    }

    
}
