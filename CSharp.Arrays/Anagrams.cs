using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class Anagrams
    {
        public static IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            if (s.Length < p.Length)
                return result;

            var pCount = new int[26];
            var sCount = new int[26];

            foreach (var c in p)
                pCount[c - 'a']++;

            for (int i = 0; i < p.Length; i++)
                sCount[s[i] - 'a']++;

            if (Matches(sCount, pCount))
                result.Add(0);

            for (int i = p.Length; i < s.Length; i++)
            {
                sCount[s[i] - 'a']++;
                sCount[s[i - p.Length] - 'a']--;

                if (Matches(sCount, pCount))
                    result.Add(i - p.Length + 1);
            }

            return result;
        }

        private static bool Matches(int[] sCount, int[] pCount)
        {
            for (int i = 0; i < 26; i++)
            {
                if (sCount[i] != pCount[i])
                    return false;
            }
            return true;
        }

    }
}
