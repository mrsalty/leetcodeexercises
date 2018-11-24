using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class ThreeSumTests
    {
        private ThreeSum.Solution _sut;

        public ThreeSumTests()
        {
            _sut = new ThreeSum.Solution();
        }

        [Test]
        public void Test()
        {
            //var nums = new int[] {-1, 0, 1, 2, -1, -4};
            var nums = new int[] { 0,0,0 };
            var result = _sut.ThreeSum(nums);

        }
    }
}
