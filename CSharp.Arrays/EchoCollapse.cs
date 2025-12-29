using System;
using System.Collections.Generic;

namespace CSharp.Arrays
{
    public class EchoCollapse
    {
        public static int[] Collapse(int[] arr, int D)
        {
            List<int> result = new List<int>();

            Dictionary<int, List<int>> valueIndices = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                bool collapsed = false;

                if (valueIndices.ContainsKey(current))
                {
                    var indices = valueIndices[current];
                    for (int j = indices.Count - 1; j >= 0; j--)
                    {
                        int prevIndex = indices[j];
                        if (i - prevIndex <= D)
                        {
                            result[prevIndex] = int.MinValue; 
                            indices.RemoveAt(j);
                            collapsed = true;
                            break;
                        }
                    }
                }

                if (!collapsed)
                {
                    int resIndex = result.Count;
                    result.Add(current);
                    if (!valueIndices.ContainsKey(current))
                        valueIndices[current] = new List<int>();
                    valueIndices[current].Add(resIndex);
                }
            }
            result.RemoveAll(x => x == int.MinValue);

            return result.ToArray();
        }
    }
}
