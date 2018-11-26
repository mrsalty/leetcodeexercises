using System;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class SearchInRotatedSortedArray
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (nums == null || nums.Length == 0) return -1;
                return SearchRotatedSortedArray(nums, target);
            }

            private int SearchRotatedSortedArray(int[] nums, int target, bool trackIndex = false)
            {
                var middelItemIndex = nums.Length / 2;
                var middleItem = nums[middelItemIndex];
                var firstItem = nums[0];
                var lastItem = nums[nums.Length - 1];

                if (target == middleItem)
                {
                    return middelItemIndex;
                }

                //left side is ordered and target in range OR left side not ordered but target > firstitem
                if (firstItem < middleItem && target <= middleItem && target >= firstItem ||
                    firstItem > middleItem && target >= firstItem)
                {
                    var leftSide = new int[middelItemIndex];
                    Array.Copy(nums, leftSide, middelItemIndex);
                    if (trackIndex)
                    {
                        var result = SearchRotatedSortedArray(leftSide, target, true);
                        if (result == -1) return -1;
                        return middelItemIndex + result;
                    }
                    return SearchRotatedSortedArray(leftSide, target);
                }

                //right side is ordered and target in range OR right side not ordered but target < lastitem
                if (lastItem > middleItem && target >= middleItem && target <= lastItem ||
                    lastItem < middleItem && target <= lastItem)
                {
                    var rightSide = new int[nums.Length - 1 - middelItemIndex];
                    Array.Copy(nums, middelItemIndex + 1, rightSide, 0, nums.Length - 1 - middelItemIndex);
                    var result = SearchRotatedSortedArray(rightSide, target, true);
                    if (result == -1) return -1;
                    return middelItemIndex + result;
                }

                return -1;
            }
        }
    }
}
