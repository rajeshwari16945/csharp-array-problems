using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SilentPairCounter
    {
        public static void GetCount()
        {
            int[] arr = { 23, 29, 41, 48, 50, 51, 77 };
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int first = arr[i] / 10;
                int second = arr[i + 1] / 10;

                if (first == second)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
