using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    class TwoSumTests
    {
        private readonly TwoSum.Solution _sut;

        public TwoSumTests()
        {
            _sut = new TwoSum.Solution();
        }

        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 2, 3, 11, 8 }, 10, new[] { 0, 3 })]
        [TestCase(new[] { 0, 4, 3, 0 }, 0, new[] { 0, 3 })]
        [TestCase(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void GivenArrayOfIntegers_ThenReturnUniqueSumIndexes(int[] nums, int target, int[] exptected)
        {
            var result = _sut.TwoSum(nums, target);
            Assert.AreEqual(exptected, result);
        }
    }
}
