using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class MaxProfitTests
    {
        private MaxProfit.Solution _sut;

        public MaxProfitTests()
        {
            _sut = new MaxProfit.Solution();
        }

        [Test]
        [TestCase(new[]{ 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new[]{ 7, 6, 4, 3, 1 }, 0)]
        [TestCase(new[] { 1, 2 }, 1)]
        [TestCase(new[] { 2, 1, 2, 0, 1 }, 1)]
        public void TestMaxProfit(int[] prices, int expected)
        {
            var result = _sut.MaxProfit(prices);
            Assert.AreEqual(expected, result);
        }
    }
}
