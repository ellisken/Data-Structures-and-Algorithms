using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        //Test for when value is in array
        [Fact]
        public void TargetInArray()
        {
            int[] testArr = { 1, 5, 6, 8, 10 };
            Assert.Equal(3, Program.BinarySearch(testArr, 8));
        }

        //Test for when value is not in array
        [Fact]
        public void TargetNotInArray()
        {
            int[] testArr = { 1, 5, 6, 8, 10 };
            Assert.Equal(-1, Program.BinarySearch(testArr, 21));
        }

        //Test for when array is empty
        [Fact]
        public void emptyArray()
        {
            int[] testArr = {};
            Assert.Equal(-1, Program.BinarySearch(testArr, 21));
        }

    }
}
