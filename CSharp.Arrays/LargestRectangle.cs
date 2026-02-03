using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class LargestRectangle
    {
        public static int Area(int[] heights)
        {
            int n = heights.Length;
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;

            for (int i = 0; i <= n; i++)
            {
                int currentHeight = (i == n) ? 0 : heights[i];

                while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
                {
                    int height = heights[stack.Pop()];
                    int width;

                    if (stack.Count == 0)
                        width = i;
                    else
                        width = i - stack.Peek() - 1;

                    maxArea = Math.Max(maxArea, height * width);
                }

                stack.Push(i);
            }

            return maxArea;
        }
    }
}
