using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercises
{
    public class IsPowerOfThree
    {
        public class Solution
        {
            public bool IsPowerOfThree(Int64 n)
            {
                return IsPowerOfThreeRecursive(3, n);
            }

            private bool IsPowerOfThreeRecursive(Int64 value, Int64 target)
            {
                if (target == 1) return true;
                if (value == target) return true;
                if (value > target) return false;
                return IsPowerOfThreeRecursive(3 * value, target);
            }
        }
    }
}
