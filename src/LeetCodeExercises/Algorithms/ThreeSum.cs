using System;
using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
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

                Array.Sort(nums);

                for (var i = 0; i < nums.Length - 2; i++)
                {
                    if (i > 0 && nums[i] == nums[i - 1]) continue;

                    var front = i + 1;
                    var end = nums.Length - 1;

                    while (front < end)
                    {
                        var next = nums[front];
                        var last = nums[end];
                        var sum = next + nums[i] + last;

                        if (sum == 0)
                        {
                            ret.Add(new[] { nums[i], next, last });
                            while (front < end && nums[front] == nums[front + 1]) front++;
                            while (front < end && nums[end] == nums[end - 1]) end--;
                            front++;
                            end--;
                        }
                        else if (sum > 0)
                        {
                            end--;
                        }
                        else if (sum < 0)
                        {
                            front++;
                        }
                    }
                }

                return ret;
            }
        }
    }
}
