using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    class IsPowerOfThreeTests
    {
        private IsPowerOfThree.Solution _sut;

        public IsPowerOfThreeTests()
        {
            _sut = new IsPowerOfThree.Solution();
        }

        [TestCase(9, true)]
        [TestCase(27, true)]
        [TestCase(21, false)]
        [TestCase(0, false)]
        [TestCase(1, true)]
        public void GivenNumber_ThenCheckIfPowertOfThree(int value, bool expected)
        {
            Assert.AreEqual(expected, _sut.IsPowerOfThree(value));
        }
    }
}
