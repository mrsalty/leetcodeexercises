using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/powx-n/
    /// Implement pow(x, n), which calculates x raised to the power n (xn).
    /// Note:
    /// -100.0 < x < 100.0
    /// n is a 32-bit signed integer, within the range[−231, 231 − 1]
    /// </summary>
    public class Pow
    {
        public class Solution
        {
            public double MyPow(double x, int n)
            {
                if (n == 0) return 1;
                return n > 0 ? PowRecursive(x, 1, n, 1) : 1 / PowRecursive(x, 1, n, 1);
            }

            private double PowRecursive(double x, double result, int n, int current)
            {
                if (result <= 0.00000) return 0;
                return current == Math.Abs(n) ? result * x : Math.Round(PowRecursive(x, result * x, n, ++current), 5);
            }
        }
    }
}
