using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises
{
    public class ThreeSum
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
        /// Find all unique triplets in the array which gives the sum of zero.
        /// Note: The solution set must not contain duplicate triplets.
        /// </summary>
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                var ret = new List<IList<int>>();
                for (var i = 2; i < nums.Length; i++)
                {
                    for (var j = 1; j < i; j++)
                    {
                        for (var k = 0; k < j; k++)
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                var arr = new[] {nums[i], nums[j], nums[k]};
                                Array.Sort(arr);
                                if (!ret.Any(x => x[0] == arr[0] && x[1] == arr[1] && x[2] == arr[2]))
                                {
                                    ret.Add(arr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }
    }
}
