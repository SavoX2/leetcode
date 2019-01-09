using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            int[] indices = new TwoSum().TwoSumDictionary(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine(indices[0] + ", " + indices[1]);
            Console.ReadKey();
        }

        public int[] TwoSumBrute(int[] nums, int target) // O(n^2)
        {
            for(int i = 0; i < nums.Length; ++i)
                for(int j = i + 1; j < nums.Length; ++j)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }

        public int[] TwoSumDictionary(int[] nums, int target) // O(n) jer Dictionary ima O(1)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                int complement = target - nums[i];
                if (dictionary.ContainsKey(complement))
                    return new int[] { dictionary[complement], i };
                dictionary.Add(nums[i], i);
            }
            return null;
        }

    }
}
