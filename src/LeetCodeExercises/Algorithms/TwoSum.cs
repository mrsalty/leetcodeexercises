using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
{
    public class TwoSum
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// </summary>
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var dictionary = new Dictionary<int, int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    var lookupValue = target - nums[i];
                    if (!dictionary.ContainsKey(lookupValue) && !dictionary.ContainsKey(nums[i]))
                    {
                        dictionary.Add(nums[i], i);
                    }
                    else if (dictionary.ContainsKey(lookupValue))
                    {
                        return new[] { dictionary[lookupValue], i };
                    }
                }
                return new[] { -1, -1 };
            }
        }
    }
}
