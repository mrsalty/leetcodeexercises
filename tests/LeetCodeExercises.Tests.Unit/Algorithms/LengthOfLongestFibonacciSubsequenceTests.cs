using System;
using System.Collections.Generic;
using System.Text;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class LengthOfLongestFibonacciSubsequenceTests
    {
        private readonly LengthOfLongestFibonacciSubsequence.Solution _sut;

        public LengthOfLongestFibonacciSubsequenceTests()
        {
            _sut = new LengthOfLongestFibonacciSubsequence.Solution();
        }

        [Ignore("WIP")]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5)]     // [1,2,3,5,8]
        [TestCase(new[] { 1, 3, 7, 11, 12, 14, 18 }, 3)]    // [1,11,12], [3,11,14] or [7,11,18]
        public void GivenArrayOfNums_ThenCalculateLengthOfLongestFibonacciSubsequence(int[] nums, int expected)
        {
            Assert.AreEqual(expected, _sut.LenLongestFibSubseq(nums));
        }
    }
}