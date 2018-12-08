using System.Collections.Generic;
using LeetCodeExercises.Algorithms;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit.Algorithms
{
    class DiameterOfBinaryTreeTests
    {
        private readonly DiameterOfBinaryTree.Solution _sut;

        public DiameterOfBinaryTreeTests()
        {
            _sut = new DiameterOfBinaryTree.Solution();
        }

        [TestCaseSource(nameof(TestCase1))]
        [TestCaseSource(nameof(TestCase2))]
        [TestCaseSource(nameof(TestCase3))]
        [TestCaseSource(nameof(TestCase4))]
        public void GivenBinaryTree_CalculateDiameter(DiameterOfBinaryTree.TreeNode root, int expected)
        {
            Assert.AreEqual(expected, _sut.DiameterOfBinaryTree(root));
        }

        private static IEnumerable<TestCaseData> TestCase1()
        {
            yield return new TestCaseData(
                new DiameterOfBinaryTree.TreeNode(1)
                {
                    left = new DiameterOfBinaryTree.TreeNode(2)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(4),
                        right = new DiameterOfBinaryTree.TreeNode(5)
                    },
                    right = new DiameterOfBinaryTree.TreeNode(3)
                },
                3);
        }

        private static IEnumerable<TestCaseData> TestCase2()
        {
            yield return new TestCaseData(
                new DiameterOfBinaryTree.TreeNode(1)
                {
                    left = new DiameterOfBinaryTree.TreeNode(2)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(4)
                    },
                    right = new DiameterOfBinaryTree.TreeNode(3)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(5),
                        right= new DiameterOfBinaryTree.TreeNode(6)
                    }
                },
                4);
        }

        private static IEnumerable<TestCaseData> TestCase3()
        {
            yield return new TestCaseData(null,
                0);
        }

        private static IEnumerable<TestCaseData> TestCase4()
        {
            yield return new TestCaseData(
                new DiameterOfBinaryTree.TreeNode(1)
                {
                    left = new DiameterOfBinaryTree.TreeNode(2)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(4)
                    },
                    right = new DiameterOfBinaryTree.TreeNode(3)
                },
                3);
        }
    }
}
