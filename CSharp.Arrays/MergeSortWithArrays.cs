using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MergeSortWithArrays
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                // Sort first half
                MergeSort(arr, left, mid);
                // Sort second half
                MergeSort(arr, mid + 1, right);
                // Merge the two halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            // Copy data
            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);
            int i = 0, j = 0, k = left;
            // Merge arrays
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            // Copy remaining elements
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

    }
}
