using System;
using System.Linq;

public class ParityLockArray
{
    public static bool CanMakeAllEven(long[] arr)
    {
        int evenXor = 0, oddXor = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int parity = (int)(arr[i] & 1);
            if ((i & 1) == 0)
                evenXor ^= parity;
            else
                oddXor ^= parity;
        }

        return evenXor == oddXor;
    }

}
