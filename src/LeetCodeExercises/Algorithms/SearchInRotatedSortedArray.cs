namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
    /// (i.e., [0, 1, 2, 4, 5, 6, 7] might become[4, 5, 6, 7, 0, 1, 2]).
    /// You are given a target value to search.If found in the array return its index, otherwise return -1.
    /// You may assume no duplicate exists in the array.
    /// Your algorithm's runtime complexity must be in the order of O(log n).
    /// </summary>
    public class SearchInRotatedSortedArray
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (nums == null || nums.Length == 0) return -1;

                var low = 0;
                var high = nums.Length - 1;
                var middle = 0;
                while (low < high)
                {
                    middle = (low + high) / 2;

                    if (nums[middle] > nums[high])
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle;
                    }
                }

                var slide = low;
                low = 0;
                high = nums.Length - 1;

                while (low <= high)
                {
                    middle = (low + high) / 2;
                    var slideMiddle = (middle + slide) % nums.Length;

                    if (target == nums[slideMiddle])
                        return slideMiddle;

                    if (nums[slideMiddle] < target)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }
                }

                return -1;

            }
        }
    }
}
