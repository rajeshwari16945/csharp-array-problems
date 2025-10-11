using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class NoOfRepetitiveNumbersInArray
    {
        public void GetNoOfEachELements()
        {
            int[] a = { 2, 5, 3, 2, 3, 4, 5, 2, 3 };
            Dictionary<int, int> counts = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++) 
            {
                if (counts.ContainsKey(a[i]))
                {
                    counts[a[i]] = counts[a[i]] + 1;
                } else
                {
                    counts[a[i]] = 1;
                }
            }
            foreach(var item in counts)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
