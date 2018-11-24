using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class ValidParenthesisTests
    {
        private ValidParenthesis.Solution _sut;

        public ValidParenthesisTests()
        {
            _sut = new ValidParenthesis.Solution();
        }

        [Test]
        [TestCase("{", false)]
        [TestCase("{ ", false)]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("{[()]}", true)]
        [TestCase("{[( ) ] }", true)]
        [TestCase("{[([{({})}])]}", true)]
        [TestCase("{[()]}}", false)]
        [TestCase("(([]){})", true)]

        public void GivenParentesis_ValidateCorrectly(string parentesis, bool expected)
        {
            var result = _sut.IsValid(parentesis);

            Assert.AreEqual(expected, result);
        }
    }
}
