using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ReArrangeArray
    {
        public static void rearrangeArray()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(input[i]);

            bool flag = true; 

            for (int i = 0; i < n - 1; i++)
            {
                if (flag)
                {
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
                else
                {
                    if (arr[i] < arr[i + 1])
                        Swap(arr, i, i + 1);
                }
                flag = !flag; 
            }

            Console.WriteLine("\nZig-Zag Array: ");
            foreach (int num in arr)
                Console.Write(num + " ");
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
