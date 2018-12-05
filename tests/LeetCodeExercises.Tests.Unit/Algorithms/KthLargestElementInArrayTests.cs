using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class KthLargestElementInArrayTests
    {
        private readonly KthLargestElementInArray.Solution _sut;

        public KthLargestElementInArrayTests()
        {
            _sut = new KthLargestElementInArray.Solution();
        }

        [TestCase(new[] {3, 2, 1, 5, 6, 4}, 2, 5)]
        public void GivenArray_ThenFindKthLargestElement(int[] arr, int k, int expected)
        {
            Assert.AreEqual(expected, _sut.FindKthLargest(arr, k));
        }
    }
}
