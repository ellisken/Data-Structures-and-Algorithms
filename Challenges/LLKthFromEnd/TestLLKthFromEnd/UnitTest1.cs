using System;
using Xunit;
using LLKthFromEnd;
using LinkedList.Classes;

namespace TestLLKthFromEnd
{
    public class UnitTest1
    {
        //Test when K is in range and edge cases
        [Theory]
        [InlineData (3, 3)]
        [InlineData (6, 0)]
        [InlineData (1, 5)]
        
        public void KIsInRange(int expected, int k)
        {
            //Create new linked list
            LList ll = new LList(new Node(1));
            ll.Append(new Node(2));
            ll.Append(new Node(3));
            ll.Append(new Node(4));
            ll.Append(new Node(5));
            ll.Append(new Node(6));

            Assert.Equal(expected, Program.GetKthFromEndLL(ll, k));
        }

        //Test when k is out of range
        [Fact]
        public void KIsOutOfRange()
        {
            //Create new linked list
            LList ll = new LList(new Node(1));
            ll.Append(new Node(2));
            ll.Append(new Node(3));
            ll.Append(new Node(4));
            ll.Append(new Node(5));
            ll.Append(new Node(6));

            var exception = Record.Exception(() => Program.GetKthFromEndLL(ll, 6));
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception);
        }
    }
}
