using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
    /// Note:
    /// Your algorithm should run in linear runtime complexity.Could you implement it using only constant extra space complexity?
    /// </summary>
    public class MissingNumber
    {
        public class Solution
        {
            public int MissingNumber(int[] nums)
            {
                Array.Sort(nums);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != i)
                        return i;
                }
                return nums[nums.Length - 1] + 1;
            }
        }
    }
}
