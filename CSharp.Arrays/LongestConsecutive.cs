using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LongestConsecutive
    {
        public static void PrintLongestConsecutive()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

                    longest = Math.Max(longest, currentLength);
                }
            }

            Console.WriteLine("Longest consecutive sequence length: " + longest);
        }

    }
}
