using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class CountApplesOranges
    {
        public static void countApplesAndOranges()
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = { -2, 2, 1 };
            int[] oranges = { 5, -6 };
            int appleCount = 0;
            int orangeCount = 0;

            // Count apples
            foreach (int apple in apples)
            {
                int appleVal = a + apple;
                if (appleVal >= s && appleVal <= t)
                    appleCount++;
            }

            // Count oranges
            foreach (int orange in oranges)
            {
                int orangeVal = b + orange;
                if (orangeVal >= s && orangeVal <= t)
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

    }
}
