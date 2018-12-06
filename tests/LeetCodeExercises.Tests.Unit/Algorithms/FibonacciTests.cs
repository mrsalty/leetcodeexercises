using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class FibonacciTests
    {
        private readonly Fibonacci _sut;

        public FibonacciTests()
        {
            _sut = new Fibonacci();
        }

        //1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(6, 13)]
        [TestCase(15, 987)]
        public void GivenIndex_ThenGetFibonacci(int n, int expected)
        {
            Assert.AreEqual(expected, _sut.GetFibonacciByIndex(n));
        }
    }
}
