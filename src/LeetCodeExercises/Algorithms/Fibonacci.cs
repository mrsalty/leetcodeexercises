namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// No LeetCode
    /// </summary>
    public class Fibonacci
    {
        public int GetFibonacciByIndex(int n)
        {
            var computed = new int?[n + 1];

            return GetFibonacciDP(n, computed);
        }

        private int GetFibonacciDP(int n, int?[] computed)
        {
            if (computed[n] != null) return computed[n].Value;

            if (n == 0 || n == 1) return 1;
            var prev1 = GetFibonacciDP(n - 1, computed);
            var prev2 = GetFibonacciDP(n - 2, computed);
            computed[n] = prev1 + prev2;
            return computed[n].Value;
        }
    }
}
