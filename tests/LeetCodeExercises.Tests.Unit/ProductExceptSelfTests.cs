using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class ProductExceptSelfTests
    {
        private readonly ProductExceptSelf.Solution _sut;

        public ProductExceptSelfTests()
        {
            _sut = new ProductExceptSelf.Solution();
        }

        [TestCase(new[] { 3, 7, 2, 10 }, new[] { 140, 60, 210, 42 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        public void GivenArray_ThenProductExceptSelfISReturned(int[] nums, int[] expected)
        {
            var result = _sut.ProductExceptSelf(nums);

            Assert.AreEqual(expected, result);
        }
    }
}
