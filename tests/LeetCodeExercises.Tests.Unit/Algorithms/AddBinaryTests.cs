using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class AddBinaryTests
    {
        private readonly AddBinary.Solution _sut;

        public AddBinaryTests()
        {
            _sut = new AddBinary.Solution();
        }

        [TestCase("1", "11", "100")]
        public void GivenTwoBinaries_ThenCalculateBinarySum(string a, string b, string expected)
        {
            Assert.AreEqual(expected, _sut.AddBinary(a, b));
        }
    }
}
