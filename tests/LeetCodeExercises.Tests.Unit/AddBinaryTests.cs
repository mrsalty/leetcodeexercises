using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
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
