using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ReverseOfArray
    {
        public static void GetReverse()
        {
            Console.WriteLine("Please enter the size of the array: "); 
            int size = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter the element at index " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] reverseArray = array.Reverse().ToArray();
            Console.WriteLine(string.Join(", ", reverseArray));
        }
    }
}
