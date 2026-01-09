using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    internal class SignalInterferenceZones
    {
        public static int CountInterferingPairs(int[] signals)
        {
            Dictionary<int, Queue<int>> map = new Dictionary<int, Queue<int>>();
            int count = 0;

            for (int i = 0; i < signals.Length; i++)
            {
                int strength = signals[i];

                if (!map.ContainsKey(strength))
                {
                    map[strength] = new Queue<int>();
                }

                Queue<int> indices = map[strength];

                while (indices.Count > 0 && i - indices.Peek() > strength)
                {
                    indices.Dequeue();
                }

                count += indices.Count;

                indices.Enqueue(i);
            }

            return count;
        }
    }
}
