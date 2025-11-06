using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class PositiveArray
    {
        public static void processingIntData()
        {
            Console.WriteLine("Array Demo Application");
            Console.Write("How many numbers do you want to enter? ");

            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }

            int[] numbers = new int[n];

            Console.WriteLine("\nEnter the numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
            }

            Console.WriteLine("\nYou entered:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max) max = num;
                if (num < min) min = num;
            }

            double average = (double)sum / n;

            Console.WriteLine("\n\nResults");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
