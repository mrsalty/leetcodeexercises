using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class MergeIntervalsTests
    {
        private readonly MergeIntervals.Solution _sut;

        public MergeIntervalsTests()
        {
            _sut = new MergeIntervals.Solution();
        }

        [Test]
        public void WhenMergeIntervals_MergeCorrectly()
        {
            //var arr = new Interval[]
            //{
            //    new Interval(1, 3),
            //    new Interval(2, 6),
            //    new Interval(8, 10),
            //    new Interval(15, 18),
            //};
            //var arr = new Interval[]
            //{
            //    new Interval(1, 4),
            //    new Interval(2,6),
            //    new Interval(8,12)
            //};
            var arr = new Interval[]
            {
                new Interval(2, 3),
                new Interval(4, 5),
                new Interval(6, 7),
                new Interval(8, 9),
                new Interval(1, 10),
            };
            var expected = new Interval[]
            {
                new Interval(1, 10)
            };

            var result = _sut.Merge(arr);

            var resultCount = result.Count;
            Assert.AreEqual(expected.Length, resultCount);
            for (int i = 0; i < resultCount; i++)
            {
                Assert.AreEqual(expected[i].start, result[i].start);
                Assert.AreEqual(expected[i].end, result[i].end);
            }
        }
    }
}
