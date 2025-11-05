using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class MatrixSumApp
    {
        public static void getMatrixSum()
        {
            Console.WriteLine("2D Array (Matrix) Example ");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int sum = 0;

            Console.WriteLine("\nEnter the elements of the matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine("\nMatrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nSum of all elements: {sum}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
