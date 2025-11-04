using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class FindMinAndMaxInArray
    {
        public static void FindAndPrintMinMax()
        {
            Console.WriteLine("Find Largest and Smallest Numbers ");

            Console.Write("Enter how many numbers: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int largest = numbers[0];
            int smallest = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > largest)
                    largest = numbers[i];

                if (numbers[i] < smallest)
                    smallest = numbers[i];
            }

            Console.WriteLine("\nNumbers entered:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine($"\n\nLargest number = {largest}");
            Console.WriteLine($"Smallest number = {smallest}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
