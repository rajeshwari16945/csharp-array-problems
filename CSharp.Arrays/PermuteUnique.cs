using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class PermuteUnique
    {

        public void GetPermuteUnique(int[] nums)
        {
            var results = new List<IList<int>>();
            Array.Sort(nums);
            var used = new bool[nums.Length];
            Backtrack(nums, new List<int>(), used, results);
            foreach (var perm in results)
            {
                Console.WriteLine(string.Join(", ", perm));
            }
        }

        private void Backtrack(int[] nums, List<int> current, bool[] used, IList<IList<int>> results)
        {
            if (current.Count == nums.Length)
            {
                results.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i])
                    continue;

                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                    continue;

                used[i] = true;
                current.Add(nums[i]);
                Backtrack(nums, current, used, results);
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
