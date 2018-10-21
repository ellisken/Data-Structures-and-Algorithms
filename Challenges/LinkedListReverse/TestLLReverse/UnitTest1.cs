using System;
using LinkedList.Classes;
using LinkedListReverse;
using Xunit;

namespace TestLLReverse
{
    public class UnitTest1
    {
        /* Tests for less efficient reveral LinkedListReverse() */
        
        //Test correct reversal for list of length 4
        [Fact]
        public void TestLength4LLR()
        {
            LList testList = new LList(new Node(1));
            testList.Append(new Node(2));
            testList.Append(new Node(3));
            testList.Append(new Node(4));

            Program.LinkedListReverse(testList);

            Assert.Equal(4, testList.Head.Value);
        }

        //Test correct reversal for list of length 2
        [Fact]
        public void TestLength2LLR()
        {
            LList testList = new LList(new Node(1));
            testList.Append(new Node(2));

            Program.LinkedListReverse(testList);

            Assert.Equal(2, testList.Head.Value);
        }

        //Test correct reversal for list of length 1
        [Fact]
        public void TestLength1LLR()
        {
            LList testList = new LList(new Node(1));

            Program.LinkedListReverse(testList);

            Assert.Equal(1, testList.Head.Value);
        }


        /* Tests LinkedListReverseInPlace() */

        //Test correct reversal for list of length 4
        [Fact]
        public void TestLength4LLRIP()
        {
            LList testList = new LList(new Node(1));
            testList.Append(new Node(2));
            testList.Append(new Node(3));
            testList.Append(new Node(4));

            Program.LinkedListReverseInPlace(testList);

            Assert.Equal(4, testList.Head.Value);
        }

        //Test correct reversal for list of length 2
        [Fact]
        public void TestLength2LLRIP()
        {
            LList testList = new LList(new Node(1));
            testList.Append(new Node(2));

            Program.LinkedListReverseInPlace(testList);

            Assert.Equal(2, testList.Head.Value);
        }

        //Test correct reversal for list of length 1
        [Fact]
        public void TestLength1LLRIP()
        {
            LList testList = new LList(new Node(1));

            Program.LinkedListReverseInPlace(testList);

            Assert.Equal(1, testList.Head.Value);
        }
    }
}
