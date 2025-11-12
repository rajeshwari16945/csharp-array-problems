using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ShiftAndSumArray
    {
        public static void ShiftAndCalSum()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Console.Write("Enter number of shifts (K): ");
            int k = int.Parse(Console.ReadLine());

            k = k % n;

            int[] shifted = new int[n];
            for (int i = 0; i < n; i++)
            {
                shifted[(i + k) % n] = arr[i];
            }

            int sum = 0;
            for (int i = 0; i < n; i += 2)
            {
                sum += shifted[i];
            }

            Console.WriteLine("Shifted Array: " + string.Join(" ", shifted));
            Console.WriteLine("Sum of elements at even indices: " + sum);
        }
    }
}
