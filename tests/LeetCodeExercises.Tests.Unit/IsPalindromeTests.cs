﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class IsPalindromeTests
    {
        private readonly IsPalindrome.Solution _sut;

        public IsPalindromeTests()
        {
            _sut = new IsPalindrome.Solution();
        }

        [TestCase(".,", false)]
        [TestCase("0P", false)]
        [TestCase("abba", true)]
        [TestCase("abcba", true)]
        [TestCase("ababababxybabababa", false)]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("amanaplanacanalpanama", true)]
        [TestCase("Sir, I demand, I am a maid named Iris", true)]
        [TestCase("Bob: \"Did Anna peep ?\" Anna:\"Did Bob?\"", true)]
        public void GivenString_ReturnIsPalindrome(string str, bool result)
        {
            var isPalindrome = _sut.IsPalindrome(str);
            Assert.AreEqual(result, isPalindrome);
        }
    }
}
