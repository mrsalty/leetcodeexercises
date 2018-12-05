using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence/
    /// Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
    /// Your algorithm should run in O(n) complexity.
    /// </summary>
    public class LongestConsecutiveSequence
    {
        public class Solution
        {
            //TODO : improve performance NOT ACCEPTED
            public int LongestConsecutive(int[] nums)
            {
                var set = new ArrayList(nums);

                var maxSequence = 0;
                for (var i = 0; i < set.Count; i++)
                {
                    var currentMax = 1;
                    var sequent = (int)set[i] + 1;
                    while (set.Contains(sequent))
                    {
                        currentMax++;
                        sequent = sequent + 1;
                    }

                    maxSequence = currentMax > maxSequence ? currentMax : maxSequence;
                }

                return maxSequence;
            }
        }
    }
}
