using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class PowTests
    {
        private readonly Pow.Solution _sut;

        public PowTests()
        {
            _sut = new Pow.Solution();
        }

        [TestCase(2.00000, 0, 1.00000)]
        [TestCase(2.00000, 10, 1024.00000)]
        [TestCase(2.10000, 3, 9.26100)]
        [TestCase(2.00000, -2, 0.25000)]
        [TestCase(2.00000, 3, 8.00000)]
        [TestCase(3.00000, 4, 81.00000)]
        [TestCase(3.00000, 3, 27.00000)]
        [TestCase(0.00001, 2147483647, 0.00000)]
        //TODO:[TestCase(1.00001, 123456, 3.43684)] => stackoverflow
        public void GivenDoubleAndInteger_ThenCalculatePow(double x, int n, double expected)
        {
            var result = _sut.MyPow(x, n);
            Assert.AreEqual(expected, result);
        }
    }
}
