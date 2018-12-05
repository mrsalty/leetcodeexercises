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

        [Test]
        public void MeetingRoomsTest1()
        {
            var intervals = new[]
            {
                new Interval(1, 3),
                new Interval(6, 9),
                new Interval(2, 4)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void MeetingRoomsTest2()
        {
            var intervals = new[]
            {
                new Interval(13, 15),
                new Interval(1, 13)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(1, result);

        }

        [Test]
        public void MeetingRoomsTest3()
        {
            var intervals = new[]
            {
                new Interval(9,10),
                new Interval(4,9),
                new Interval(4,17)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void MeetingRoomsTest4()
        {
            var intervals = new[]
            {
                new Interval(1,3),
                new Interval(6,9),
                new Interval(2,4),
                new Interval(8,10),
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }
    }

}