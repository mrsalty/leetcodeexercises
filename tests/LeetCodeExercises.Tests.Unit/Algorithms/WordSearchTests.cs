using System.Collections.Generic;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class WordSearchTests
    {
        private readonly WordSearch.Solution _sut;

        public WordSearchTests()
        {
            _sut = new WordSearch.Solution();
        }

        [TestCaseSource(nameof(TestData1))]
        [TestCaseSource(nameof(TestData2))]
        [TestCaseSource(nameof(TestData3))]
        [TestCaseSource(nameof(TestData4))]
        public void GivenCharBoard_ThenSearchWord(char[,] board, string word, bool exptected)
        {
            var result = _sut.Exist(board, word);
            Assert.AreEqual(exptected, result);
        }

        public static IEnumerable<TestCaseData> TestData1()
        {
            yield return new TestCaseData(new[,]
                {
                    {'A', 'B', 'C', 'E'},
                    {'S', 'F', 'C', 'S'},
                    {'A', 'D', 'E', 'E'},
                },
                "ABCCED", true);
        }

        public static IEnumerable<TestCaseData> TestData2()
        {
            yield return new TestCaseData(new[,]
                {
                    {'A', 'B', },
                    {'C', 'D', }
                },
                "ABCD", false);
        }

        public static IEnumerable<TestCaseData> TestData3()
        {
            yield return new TestCaseData(new[,]
                {
                    {'A', 'B', 'C', 'E'},
                    {'S', 'F', 'E', 'S'},
                    {'A', 'D', 'E', 'E'},
                },
                "ABCESEEEFS", true);
        }
        
        public static IEnumerable<TestCaseData> TestData4()
        {
            yield return new TestCaseData(new[,]
                {
                    {'A', 'B', 'C', 'E'},
                    {'S', 'F', 'C', 'S'},
                    {'A', 'D', 'E', 'E'},
                },
                "ABCB", false);
        }
    }
}
