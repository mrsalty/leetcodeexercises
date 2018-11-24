using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class MeetingRoomsIITests
    {
        private readonly MeetingRoomsII.Solution _sut;

        public MeetingRoomsIITests()
        {
            _sut = new MeetingRoomsII.Solution();
        }

        [Test]
        public void MeetingRoomsTest1()
        {
            var intervals = new[]
            {
                new MeetingRoomsII.Interval(1, 3),
                new MeetingRoomsII.Interval(6, 9),
                new MeetingRoomsII.Interval(2, 4)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void MeetingRoomsTest2()
        {
            var intervals = new[]
            {
                new MeetingRoomsII.Interval(13, 15),
                new MeetingRoomsII.Interval(1, 13)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(1, result);

        }

        [Test]
        public void MeetingRoomsTest3()
        {
            var intervals = new[]
            {
                new MeetingRoomsII.Interval(9,10),
                new MeetingRoomsII.Interval(4,9),
                new MeetingRoomsII.Interval(4,17)
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void MeetingRoomsTest4()
        {
            var intervals = new[]
            {
                new MeetingRoomsII.Interval(1,3),
                new MeetingRoomsII.Interval(6,9),
                new MeetingRoomsII.Interval(2,4),
                new MeetingRoomsII.Interval(8,10),
            };

            var result = _sut.MinMeetingRooms(intervals);

            Assert.AreEqual(2, result);

        }
    }

}