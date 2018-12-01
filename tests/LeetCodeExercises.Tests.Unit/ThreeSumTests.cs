using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class ThreeSumTests
    {
        private readonly ThreeSum.Solution _sut;

        public ThreeSumTests()
        {
            _sut = new ThreeSum.Solution();
        }

        [Test]
        [TestCaseSource(nameof(ThreeSumTestCaseSource1))]
        [TestCaseSource(nameof(ThreeSumTestCaseSource2))]
        [TestCaseSource(nameof(ThreeSumTestCaseSource3))]
        public void GivenArrayOfIntegrers_ThenCalculateThreeSumsEqualZero(int[] nums, int[,] expected)
        {
            var threeSum = _sut.ThreeSum(nums);
            var expectedList = ToList(expected);
            Assert.AreEqual(expectedList.Count, threeSum.Count);
            foreach (var item in expectedList)
            {
                Assert.NotNull(threeSum.SingleOrDefault(x => x[0] == item[0] && x[1] == item[1] && x[2] == item[2]));
            }
        }

        public static IEnumerable<TestCaseData> ThreeSumTestCaseSource1()
        {
            yield return new TestCaseData(new[] { -1, 0, 1, 2, -1, -4 }, new[,] { { -1, -1, 2 }, { -1, 0, 1 } });
        }

        public static IEnumerable<TestCaseData> ThreeSumTestCaseSource2()
        {
            yield return new TestCaseData(new[] { -10, -8, -3, 11, 18, 74 }, new[,] { { -10, -8, 18 }, { -8, -3, 11 } });
        }

        public static IEnumerable<TestCaseData> ThreeSumTestCaseSource3()
        {
            yield return new TestCaseData(new[] { -1, 0, 3, 2, 5, -1 }, new[,] { { -1, -1, 2 } });
        }

        private List<List<int>> ToList(int[,] nums)
        {
            var list = new List<List<int>>();
            var lenght = nums.GetLength(0);
            var depth = nums.GetLength(1);
            for (int i = 0; i < lenght; i++)
            {
                var item = new List<int>();
                for (int j = 0; j < depth; j++)
                {
                    item.Add(nums[i, j]);
                }
                list.Add(item);
            }

            return list;
        }

    }
}
