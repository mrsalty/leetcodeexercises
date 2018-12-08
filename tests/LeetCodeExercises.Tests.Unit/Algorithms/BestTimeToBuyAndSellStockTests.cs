using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class BestTimeToBuyAndSellStockTests
    {
        private readonly BestTimeToBuyAndSellStock.Solution _sut;

        public BestTimeToBuyAndSellStockTests()
        {
            _sut = new BestTimeToBuyAndSellStock.Solution();
        }

        [TestCase(new int[] {}, 0)]
        [TestCase(new[] {2, 4, 1}, 2)]
        [TestCase(new[] { 2, 1, 5, 6, 4 }, 5)]
        [TestCase(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new[] { 7, 3, 5, 1, 8, 4 }, 7)]
        [TestCase(new[] { 7, 1, 5, 2, 2, 4 }, 4)]
        [TestCase(new[] { 1, 1, 5, 2, 2, 12 }, 11)]
        [TestCase(new[] { 7, 6, 4, 3, 1 }, 0)] //no transaction possible
        [TestCase(new[] { 3, 3 }, 0)] //no transaction possible
        public void GivenPriceArray_ThenFindBestTimeToBuyAndSellStock(int[] prices, int expected)
        {
            Assert.AreEqual(expected, _sut.MaxProfit(prices));
        }
    }
}
