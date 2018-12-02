using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercises
{
    public class MoveZeroes
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 0)
                    {
                        var indexToSwap = i + 1;
                        while (indexToSwap < nums.Length - 1 && nums[indexToSwap] == 0)
                        {
                            indexToSwap++;
                        }

                        var tmp = nums[indexToSwap];
                        nums[indexToSwap] = 0;
                        nums[i] = tmp;
                    }
                }
            }
        }
    }
}
