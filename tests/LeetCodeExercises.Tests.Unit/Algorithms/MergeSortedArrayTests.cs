using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class MergeSortedArrayTests
    {
        private readonly MergeSortedArray.Solution _sut;

        public MergeSortedArrayTests()
        {
            _sut = new MergeSortedArray.Solution();
        }


        [TestCase(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3, new[] {1, 2, 2, 3, 5, 6})]
        public void GivenTwoSortedArrays_ThenTheyAreMergedCorrectly(int[] arr1, int m, int[] arr2, int n, int[] exptected)
        {
            _sut.Merge(arr1, m, arr2, n);
            Assert.AreEqual(exptected, arr1);
        }
    }
}
