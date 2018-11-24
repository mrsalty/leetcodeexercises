using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeExercises.Tests.Unit
{
    public class NumberOfIslandsTests
    {
        private readonly NumberOfIslands.Solution _sut;

        public NumberOfIslandsTests()
        {
            _sut = new NumberOfIslands.Solution();
        }

        [Test]
        public void GivenInput_NumberOfIslandsIsCalculated()
        {
            var result0 = _sut.NumIslands(TestData0);
            Assert.AreEqual(1, result0);

            var result1 = _sut.NumIslands(TestData1);
            Assert.AreEqual(1, result1);

            var result2 = _sut.NumIslands(TestData2);
            Assert.AreEqual(3, result2);

            var result3 = _sut.NumIslands(TestData3);
            Assert.AreEqual(1, result3);

            var result4 = _sut.NumIslands(TestData4);
            Assert.AreEqual(3, result4);

            var result5 = _sut.NumIslands(TestData5);
            Assert.AreEqual(1, result5);

            var result6 = _sut.NumIslands(TestData6);
            Assert.AreEqual(1, result6);

        }
        public static char[,] TestData0 => new[,]
        {
            {'0', '1'},
            {'1', '1'},
        };

        public static char[,] TestData1 => new[,]
        {
            {'1', '1', '1', '1', '0'},
            {'1', '1', '0', '1', '0'},
            {'1', '1', '0', '0', '0'},
            {'0', '0', '0', '0', '0'}
        };

        public static char[,] TestData2 => new[,]
        {
            {'1', '1', '0', '0', '0'},
            {'1', '1', '0', '0', '0'},
            {'0', '0', '1', '0', '0'},
            {'0', '0', '0', '1', '1'}
        };

        public static char[,] TestData3 => new[,]
        {
            {'1', '1', '1'},
            {'0', '1', '0'},
            {'1', '1', '1'},
        };

        public static char[,] TestData4 => new[,]
        {
            {'1', '1', '0', '0', '0'},
            {'1', '1', '0', '0', '0'},
            {'0', '0', '1', '0', '0'},
            {'0', '0', '0', '1', '1'}
        };

        public static char[,] TestData5 => new[,]
        {
            {'0', '0', '1', '0', '0'},
            {'0', '0', '1', '0', '0'},
            {'1', '1', '1', '0', '0'},
        };

        public static char[,] TestData6 => new[,]
        {
            {'1', '0', '1', '1', '1'},
            {'1', '0', '1', '0', '1'},
            {'1', '1', '1', '0', '1'},
        };

        private void test()
        {
            var grid = new char[,] { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };
            var length = grid.GetLength(1);
            var height = grid.GetLength(0);

            string str = string.Empty;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    str += grid[j, i];
                }
            }
            Assert.AreEqual("ABCDEF", str);
        }
    }

}
