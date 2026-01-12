using System;

class PressureZones
{
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public static int[] ComputePressure(int[] arr)
    {
        int n = arr.Length;
        int[] pressure = new int[n];

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = i - 1; j >= 0; j--)
            {
                if (Gcd(arr[i], arr[j]) > 1)
                    count++;
                else
                    break;
            }

            for (int j = i + 1; j < n; j++)
            {
                if (Gcd(arr[i], arr[j]) > 1)
                    count++;
                else
                    break;
            }

            pressure[i] = count;
        }

        return pressure;
    }
}
