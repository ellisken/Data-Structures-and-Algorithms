using System;
using MultiBracketValidation;
using Xunit;

namespace TestBracketValidation
{
    //Test balanced string
    public class UnitTest1
    {
        [Fact]
        public void TestBalancedString()
        {
            string testString = "([[{hello}]])abc";
            Assert.True(Program.MultiBracketValidation(testString));
        }

        //Test balanced string of length 2
        [Fact]
        public void TestBalancedStringLengthTwo()
        {
            string testString = "()";
            Assert.True(Program.MultiBracketValidation(testString));
        }
   
        //Test unabalanced string
        [Fact]
        public void TestUnbalancedString()
        {
            string testString = "()[abc}";
            Assert.False(Program.MultiBracketValidation(testString));
        }

        //Test unbalanced string of length 1
        [Fact]
        public void TestUnbalancedStringLengthOne()
        {
            string testString = "(";
            Assert.False(Program.MultiBracketValidation(testString));
        }

        //Test empty string
        [Fact]
        public void TestEmptyString()
        {
            string testString = "";
            Assert.True(Program.MultiBracketValidation(testString));
        }

        //Test string with no brackets
        [Fact]
        public void TestNoBrackets()
        {
            string testString = "abc";
            Assert.True(Program.MultiBracketValidation(testString));
        }
    }

}
