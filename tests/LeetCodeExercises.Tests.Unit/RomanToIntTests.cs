using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    class RomanToIntTests
    {
        private readonly RomanToInteger.Solution _sut;

        public RomanToIntTests()
        {
            _sut = new RomanToInteger.Solution();
        }

        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XIX", 19)]
        [TestCase("XVIII", 18)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        [TestCase("MCCXLVI", 1246)]
        //1000, 100, 100, 10, 50, 5, 1
        //----  --------  ------  ----
        public void GivenRomanNumber_ThenTranslateToInteger(string roman, int expected)
        {
            Assert.AreEqual(expected, _sut.RomanToInt(roman));
        }
    }
}
