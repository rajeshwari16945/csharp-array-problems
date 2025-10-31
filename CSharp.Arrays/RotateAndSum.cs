using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class RotateAndSum
    {
        public static void RotateArrayAndGetSum()
        {
            Console.WriteLine("Enter array elements separated by space:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Enter number of rotations (K):");
            int K = int.Parse(Console.ReadLine());
            int n = arr.Length;
            int[] sumArr = new int[n];

            for (int k = 0; k < K; k++)
            {
                int last = arr[n - 1];
                for (int i = n - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;

                for (int i = 0; i < n; i++)
                {
                    sumArr[i] += arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                sumArr[i] += arr[i];
            }

            Console.WriteLine("Resulting array after rotations and sum:");
            Console.WriteLine(string.Join(", ", sumArr));
        }
    }
}
