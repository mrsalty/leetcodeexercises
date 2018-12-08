namespace LeetCodeExercises.Algorithms
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
                var output = new int[nums.Length];

                //traverse from left 
                var prod = 1;
                for (var i = 0; i < nums.Length; i++)
                {
                    output[i] = prod;
                    prod *= nums[i];
                }

                prod = 1;
                //traverse from right 
                for (var i = nums.Length - 1; i >= 0; i--)
                {
                    output[i] *= prod;
                    prod *= nums[i];
                }
                return output;
            }
        }
    }
}
