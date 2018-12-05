using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class LetterCombinationsTests
    {
        private readonly LetterCombinations.Solution _sut;

        public LetterCombinationsTests()
        {
            _sut = new LetterCombinations.Solution();
        }

        [TestCase("", new string[] { })]
        [TestCase("1", new string[] { })]
        [TestCase("4", new[] { "g", "h", "i" })]
        [TestCase("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        public void WhenDigitsExist_LetterCombinationIsReturned(string digits, string[] expected)
        {
            var result = _sut.LetterCombinations(digits);
            Assert.AreEqual(expected, result);
        }
    }
}
