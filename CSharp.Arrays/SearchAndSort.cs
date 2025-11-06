using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SearchAndSort
    {
        public static void performSearchSort()
        {
            string[] fruits = { "Apple", "Orange", "Banana", "Mango", "Grapes" };

            Console.WriteLine("Original Array:");
            PrintArray(fruits);

            Array.Sort(fruits);

            Console.WriteLine("\nSorted Array:");
            PrintArray(fruits);

            Console.Write("\nEnter a fruit to search: ");
            string search = Console.ReadLine();

            int index = Array.BinarySearch(fruits, search);

            if (index >= 0)
                Console.WriteLine($"'{search}' found at index {index}.");
            else
                Console.WriteLine($"'{search}' not found in the array.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
