using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class LongestConsecutiveSequenceTests
    {
        private readonly LongestConsecutiveSequence.Solution _sut;

        public LongestConsecutiveSequenceTests()
        {
            _sut = new LongestConsecutiveSequence.Solution();
        }

        [TestCase(new[] {100, 4, 101, 1, 3, 2}, 4)]
        public void GivenArray_ThenFindLongestConsecutiveSequence(int[] nums, int expected)
        {
            Assert.AreEqual(_sut.LongestConsecutive(nums), expected);
        }
    }
}
