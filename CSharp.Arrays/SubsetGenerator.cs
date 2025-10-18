using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SubsetGenerator
    {

        public static List<List<int>> GenerateSubsets(List<int> nums)
        {
            var result = new List<List<int>>();
            Generate(0, nums, new List<int>(), result);
            return result;
        }

        private static void Generate(int index, List<int> nums, List<int> current, List<List<int>> result)
        {
            if (index == nums.Count)
            {
                result.Add(new List<int>(current));
                return;
            }

            Generate(index + 1, nums, current, result);

            current.Add(nums[index]);
            Generate(index + 1, nums, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
