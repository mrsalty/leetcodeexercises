using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class LeastIntervalsTests
    {
        private readonly LeastIntervals.Solution _sut;

        public LeastIntervalsTests()
        {
            _sut = new LeastIntervals.Solution();
        }

        [Ignore("WIP")]
        [TestCase(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)]    //=> A -> B -> idle -> A -> B -> idle -> A -> B.
        [TestCase(new[] { 'A', 'A', 'B', 'B', 'C', 'C' }, 2, 6)]    //=> A -> B -> C -> A -> B -> C
        [TestCase(new[] { 'A', 'A', 'A', 'A', 'A', 'A' }, 2, 16)]   //=> A -> idle -> idle -> A -> idle -> idle -> A -> idle -> idle -> A -> idle -> idle -> A -> idle -> idle -> A 
        [TestCase(new[] { 'A', 'A', 'A', 'A', 'A', 'A' }, 1, 11)]   //=> A -> idle -> A -> idle -> A -> idle -> A-> idle -> A-> idle -> A
        [TestCase(new[] { 'A', 'B', 'C', 'D', 'E', 'F' }, 2, 6)]    //=> A -> B -> C -> D -> E -> F
        public void GivenArrayOfTasks_ThenCalculateLeastIntervals(char[] tasks, int n, int expected)
        {
            Assert.AreEqual(expected, _sut.LeastInterval(tasks, n));
        }
    }
}
