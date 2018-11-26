using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class SearchInRotatedSortedArrayTests
    {
        private readonly SearchInRotatedSortedArray.Solution _sut;

        public SearchInRotatedSortedArrayTests()
        {
            _sut = new SearchInRotatedSortedArray.Solution();
        }

        [TestCase(new int[] { }, 3, -1)]
        [TestCase(new[] { 3 }, 3, 0)]
        [TestCase(new[] { 25, 0 }, 0, 1)]
        [TestCase(new[] { 25, 0 }, 25, 0)]
        [TestCase(new[] { 1, 3, 5 }, 4, -1)]
        [TestCase(new[] { 1, 3, 5 }, 1, 0)]
        [TestCase(new[] { 5, 1, 3 }, 1, 1)]
        [TestCase(new[] { 1, 3, 5 }, 5, 2)]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [TestCase(new[] { 25, 0, 1 }, 25, 0)]
        [TestCase(new[] { 6, 7, 0, 1, 2, 4 }, 6, 0)]
        [TestCase(new[] { 6, 7, 0, 1, 2, 4 }, 2, 4)]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 2, 6)]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 4, 0)]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 34, -1)]
        public void WhenSortedRotatedArray_AndTarget_ThenReturnsIndex(int[] source, int target, int expected)
        {
            var result = _sut.Search(source, target);
            Assert.AreEqual(expected, result);
        }
    }
}
