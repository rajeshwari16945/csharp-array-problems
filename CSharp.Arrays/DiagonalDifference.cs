using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DiagonalDifference
    {
        public static int GetDiagDiff()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 9, 8, 9 }
            };
            int frstDiagonal = 0;
            int scndDiagonal = 0;
            int count = arr.Length;

            for (int i = 0; i < count; i++)
            {
                frstDiagonal += arr[i][i];
                scndDiagonal += arr[i][count - i - 1];
            }

            return Math.Abs(frstDiagonal - scndDiagonal);
        }
    }
}
