namespace LeetCodeExercises
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
                for (var i = 1; i < nums.Length; i++)
                {
                    for (var j = 0; j < i; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new[] { j, i };
                        }
                    }
                }

                return new[] { -1, -1 };
            }
        }
    }
}
