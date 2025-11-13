using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class CompareArrays
    {
        public static void CreateArrays()
        {
            int[] array1 = { 96, 22, 40, 59, 34 };
            int[] array2 = { 71, 52, 40, 87, 25 };
            Console.WriteLine(string.Join(",", array1));
            Console.WriteLine(string.Join(",", array2));
            Console.WriteLine("Array1, Array2" + string.Join(",", compareTwoArrays(array1, array2)));
        }

        public static int[] compareTwoArrays(int[] array1, int[] array2)
        {
            int length = Math.Min(array1.Length, array2.Length);
            int[] resultArray = new int[2];
            for (int i = 0; i < length; i++)
            {
                if (array1[i] > array2[i])
                {
                    resultArray[0]++;
                }
                else
                {
                    resultArray[1]++;
                }
            }
            return resultArray;
        }
    }
}
