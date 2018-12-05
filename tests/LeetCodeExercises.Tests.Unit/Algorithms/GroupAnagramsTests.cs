using System.Collections.Generic;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    public class GroupAnagramsTests
    {
        private readonly GroupAnagrams.Solution _sut;

        public GroupAnagramsTests()
        {
            _sut = new GroupAnagrams.Solution();
        }

        [TestCaseSource(nameof(TestCaseSource1))]
        [TestCaseSource(nameof(TestCaseSource2))]
        [TestCaseSource(nameof(TestCaseSource3))]
        public void GivenArrayOfWords_ThenGroupAnagrams(string[] words, IList<IList<string>> grouped)
        {
            var result = _sut.GroupAnagrams(words);
            Assert.AreEqual(grouped.Count, result.Count);
        }

        private static IEnumerable<TestCaseData> TestCaseSource1()
        {
            yield return new TestCaseData(
                new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new[]
                {
                    new[] { "ate", "eat", "tea" },
                    new[] { "nat", "tan" },
                    new[] { "bat" }
                });
        }

        private static IEnumerable<TestCaseData> TestCaseSource2()
        {
            yield return new TestCaseData(
                new[] { "", "" },
                new[]
                {
                    new[] { "", "" }
                });
        }

        private static IEnumerable<TestCaseData> TestCaseSource3()
        {
            yield return new TestCaseData(
                new[] {"paw", "dad", "bog", "day", "day", "mig", "len", "rat"},
                new[]
                {
                    new[] {"rat"},
                    new[] {"mig"},
                    new[] {"paw"},
                    new[] {"dad"},
                    new[] {"len"},
                    new[] {"bog"},
                    new[] {"day", "day"}
                });
        }
    }
}
