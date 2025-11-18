using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StudentGrades
    {
        public static void gradingStudents()
        {
            int[] grades = new int[] { 73, 67, 38, 33 };
            int[] result = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                int grade = grades[i];

                if (grade < 38)
                {
                    result[i] = grade;
                }
                else
                {
                    int rounded = (int)(Math.Round(grade / 5.0) * 5);

                    if (rounded < grade)
                        result[i] = grade;
                    else
                        result[i] = rounded;
                }
            }

            Console.WriteLine("Rounded Grades: " + string.Join(", ", result));
        }

    }
}
