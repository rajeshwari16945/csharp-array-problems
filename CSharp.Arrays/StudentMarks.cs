using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StudentMarks
    {
        public void calculateStudentMarks()
        {
            Console.Write("Enter number of students: ");
            int students = int.Parse(Console.ReadLine());

            Console.Write("Enter number of subjects: ");
            int subjects = int.Parse(Console.ReadLine());

            int[,] marks = new int[students, subjects];

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("\nEnter marks for Student " + (i + 1) + ":");
                for (int j = 0; j < subjects; j++)
                {
                    Console.Write("Subject " + (j + 1) + ": ");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nStudent Results:");
            for (int i = 0; i < students; i++)
            {
                int total = 0;
                int highest = marks[i, 0];
                int lowest = marks[i, 0];

                for (int j = 0; j < subjects; j++)
                {
                    int m = marks[i, j];
                    total += m;

                    if (m > highest) highest = m;
                    if (m < lowest) lowest = m;
                }

                double average = (double)total / subjects;

                Console.WriteLine("\nStudent " + (i + 1));
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Average: " + average);
                Console.WriteLine("Highest: " + highest);
                Console.WriteLine("Lowest: " + lowest);
            }
        }
    }
}
