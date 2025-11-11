using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class TemperatureTracker
    {
        public static void getTemperatureTracker()
        {
            Console.WriteLine("=== Temperature Tracker ===");

            Console.Write("Enter number of days to record temperatures for: ");
            int days;
            while (!int.TryParse(Console.ReadLine(), out days) || days <= 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }

            double[] temps = new double[days];

            Console.WriteLine("\nEnter temperatures (in °C):");
            for (int i = 0; i < days; i++)
            {
                Console.Write($"Day {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out temps[i]))
                {
                    Console.Write("Invalid input. Enter a numeric temperature: ");
                }
            }

            Console.WriteLine("\nRecorded Temperatures:");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temps[i]:F1} °C");
            }

            double avg = CalculateAverage(temps);
            double max = FindMax(temps);
            double min = FindMin(temps);

            Console.WriteLine("\n--- Temperature Stats ---");
            Console.WriteLine($"Average Temperature: {avg:F2} °C");
            Console.WriteLine($"Highest Temperature: {max:F1} °C");
            Console.WriteLine($"Lowest Temperature : {min:F1} °C");

            int aboveAvgCount = 0;
            foreach (double t in temps)
            {
                if (t > avg)
                    aboveAvgCount++;
            }

            Console.WriteLine($"Days above average: {aboveAvgCount} out of {days}");
            Console.Write("\nEnter a temperature to search for: ");
            double searchTemp;
            while (!double.TryParse(Console.ReadLine(), out searchTemp))
            {
                Console.Write("Invalid input. Enter a numeric temperature: ");
            }

            int index = Array.IndexOf(temps, searchTemp);
            if (index != -1)
            {
                Console.WriteLine($"Temperature {searchTemp:F1} °C found on Day {index + 1}.");
            }
            else
            {
                Console.WriteLine($"Temperature {searchTemp:F1} °C not found in the records.");
            }

            Console.WriteLine("\n=== End of Program ===");
        
        }

        static double CalculateAverage(double[] arr)
        {
            double total = 0;
            foreach (double t in arr)
                total += t;
            return total / arr.Length;
        }

        static double FindMax(double[] arr)
        {
            double max = arr[0];
            foreach (double t in arr)
                if (t > max)
                    max = t;
            return max;
        }

        static double FindMin(double[] arr)
        {
            double min = arr[0];
            foreach (double t in arr)
                if (t < min)
                    min = t;
            return min;
        }
    }
}
