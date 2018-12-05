using System;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.
    /// </summary>
    public class KthLargestElementInArray
    {
        public class Solution
        {
            public int FindKthLargest(int[] nums, int k)
            {
                Array.Sort(nums);
                return nums[nums.Length - k];
            }
        }
    }
}
