using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class MoveZeroesTests
    {
        private readonly MoveZeroes.Solution _sut;

        public MoveZeroesTests()
        {
            _sut = new MoveZeroes.Solution();
        }

        [TestCase(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
        [TestCase(new[] { -1, 0, 2, 0 , 3 }, new[] { -1, 2, 3, 0, 0 })]
        public void GivenArrayWithZeroes_ThenMoveZeroesAtEndOfArrayInPlace(int[] nums, int[] expected)
        {
            _sut.MoveZeroes(nums);
            Assert.AreEqual(expected, nums);
        }
    }
}
