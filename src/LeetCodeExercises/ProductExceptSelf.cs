namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// </summary>
    public class ProductExceptSelf
    {
        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                var res = new int[nums.Length];

                //traverse from left 
                var tmp = 1;
                for (var i = 0; i < nums.Length; i++)
                {
                    res[i] = tmp;
                    tmp *= nums[i];
                }

                tmp = 1;
                //traverse from right 
                for (var i = nums.Length - 1; i >= 0; i--)
                {
                    res[i] *= tmp;
                    tmp *= nums[i];
                }
                return res;
            }
        }
    }
}
