namespace LeetCodeExercises
{
    public class ProductExceptSelf
    {
        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                int[] result = new int[nums.Length];
                for (int i = 0, tmp = 1; i < nums.Length; i++)
                {
                    result[i] = tmp;
                    tmp *= nums[i];
                }
                for (int i = nums.Length - 1, tmp = 1; i >= 0; i--)
                {
                    result[i] *= tmp;
                    tmp *= nums[i];
                }
                return result;
            }
        }
    }
}
