using System.Linq;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class WordBreakTests
    {
        private readonly WordBreak.Solution _sut;

        public WordBreakTests()
        {
            _sut = new WordBreak.Solution();
        }

        [TestCase("leetcode", new[] { "leet", "code" }, true)]
        [TestCase("applepenapple", new[] { "apple", "pen" }, true)]
        [TestCase("catsandog", new[] { "cats", "dog", "sand", "and", "cat" }, false)]
        [TestCase("cars", new[] { "car", "ca", "rs" }, true)]
        [TestCase("cars", new[] { "car", "ca", "rs", "ars" }, true)]
        [TestCase("cars", new[] { "car", "ca", "ars", "rs" }, true)]
        [TestCase("applepie", new[] { "app", "le", "pi", "a", "e" }, true)]
        [TestCase("ccbb", new[] { "bc", "cb" }, false)]
        [TestCase("cbca", new[] { "bc", "ca" }, false)]
        public void GivenStringAndArrayOfStrings_ThenCheckIfWordBreakApplies(string s, string[] words, bool exptected)
        {
            Assert.AreEqual(exptected, _sut.WordBreak(s, words.ToHashSet()));
        }
    }
}
