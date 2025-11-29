using System;

class CountValuesAboveAverage
{
    public static void GetCount()
    {
        Console.Write("Enter how many numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }
        double average = sum / n;

        int countAbove = 0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > average)
                countAbove++;
        }

        Console.Write("Array: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine($"\nAverage: {average}");
        Console.WriteLine($"Numbers above average: {countAbove}");
    }
}
