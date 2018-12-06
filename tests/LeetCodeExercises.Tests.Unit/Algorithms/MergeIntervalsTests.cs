using System.Collections.Generic;
using System.Linq;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class MergeIntervalsTests
    {
        private readonly MergeIntervals.Solution _sut;

        public MergeIntervalsTests()
        {
            _sut = new MergeIntervals.Solution();
        }

        [TestCaseSource(nameof(TestCase1))]
        [TestCaseSource(nameof(TestCase2))]
        [TestCaseSource(nameof(TestCase2))]
        public void GivenIntervals_ThenMergeOverlappingIntervals(IList<Interval> intervals, IList<Interval> expected)
        {
            var result = _sut.Merge(intervals);
            Assert.AreEqual(expected.Count, result.Count);
            foreach (var item in expected)
            {
                Assert.NotNull(result.SingleOrDefault(x => x.start == item.start && x.end == item.end));
            }
        }

        private static IEnumerable<TestCaseData> TestCase1()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(2, 3),
                    new Interval(4, 5),
                    new Interval(6, 7),
                    new Interval(8, 9),
                    new Interval(1, 10),
                },
                new[]
                {
                    new Interval(1, 10)
                });
        }

        private static IEnumerable<TestCaseData> TestCase2()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(1, 3),
                    new Interval(2, 6),
                    new Interval(8, 10),
                    new Interval(15, 18),
                },
                new[]
                {
                    new Interval(1, 6),
                    new Interval(8,10),
                    new Interval(15,18)
                });
        }
        private static IEnumerable<TestCaseData> TestCase3()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(1, 5),
                    new Interval(4, 8),
                    new Interval(7, 10),
                },
                new[]
                {
                    new Interval(1, 10)
                });
        }
    }
}
