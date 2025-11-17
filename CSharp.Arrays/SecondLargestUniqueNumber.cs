using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SecondLargestUniqueNumber
    {
        public static void printNumber()
        {
            Console.WriteLine("Second Largest Unique Number ");
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] unique = arr.Distinct().ToArray();

            if (unique.Length < 2)
            {
                Console.WriteLine("No second largest number found.");
                return;
            }

            Array.Sort(unique);
            Array.Reverse(unique);

            int secondLargest = unique[1];
            Console.WriteLine($"Second Largest Unique Number: {secondLargest}");
        }
    }
}
