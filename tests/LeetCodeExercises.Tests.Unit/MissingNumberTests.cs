using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    class MissingNumberTests
    {
        private readonly MissingNumber.Solution _sut;

        public MissingNumberTests()
        {
            _sut = new MissingNumber.Solution();
        }

        [TestCase(new[] { 3, 0, 1 }, 2)]
        [TestCase(new[] { 3, 0, 1, 4, 6, 2 }, 5)]
        [TestCase(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void GivenArray_ThenFindMissingNumber(int[] nums, int expected)
        {
            var missing = _sut.MissingNumber(nums);
            Assert.AreEqual(expected, missing);
        }
    }
}
