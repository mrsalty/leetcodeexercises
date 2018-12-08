using System.Collections.Generic;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class MeetingRoomsIiTests
    {
        private readonly MeetingRoomsIi.Solution _sut;

        public MeetingRoomsIiTests()
        {
            _sut = new MeetingRoomsIi.Solution();
        }

        [TestCaseSource(nameof(TestCase1))]
        [TestCaseSource(nameof(TestCase2))]
        [TestCaseSource(nameof(TestCase3))]
        [TestCaseSource(nameof(TestCase4))]
        public void GivenIntervals_ThenCalculateMinMeetingRooms(Interval[] intervals, int expected)
        {
            Assert.AreEqual(expected, _sut.MinMeetingRooms(intervals));
        }

        [Test]
        private static IEnumerable<TestCaseData> TestCase1()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(1, 3),
                    new Interval(6, 9),
                    new Interval(2, 4)
                }, 2);
        }

        [Test]
        private static IEnumerable<TestCaseData> TestCase2()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(13, 15),
                    new Interval(1, 13)
                }, 1);
        }

        [Test]
        private static IEnumerable<TestCaseData> TestCase3()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(9,10),
                    new Interval(4,9),
                    new Interval(4,17)
                }, 2);
        }

        [Test]
        private static IEnumerable<TestCaseData> TestCase4()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Interval(1,3),
                    new Interval(6,9),
                    new Interval(2,4),
                    new Interval(8,10),
                }, 2);
        }
    }

}