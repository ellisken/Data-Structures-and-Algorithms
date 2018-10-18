using System;
using LinkedList.Classes;
using LLMerge;
using Xunit;

namespace TestMerge
{
    public class UnitTest1
    {
        //Test Merging two linked lists of same length
        [Fact]
        public void MergeTwoListsOfSameLength()
        {
            //Create new linked list
            LList ll1 = new LList(new Node(1));
            LList ll2 = new LList(new Node(5));
            ll1.Append(new Node(3));
            ll1.Append(new Node(2));
            ll2.Append(new Node(9));
            ll2.Append(new Node(4));

            LList llMerged = Program.Merge(ll1, ll2);
            int k = 0;
            Assert.Equal(4, llMerged.KthFromEnd(0));
        }

        //Test merging two linked lists of different lengths
        [Fact]
        public void MergeTwoListsOfDifferentLength()
        {
            //Create new linked list
            LList ll1 = new LList(new Node(1));
            LList ll2 = new LList(new Node(2));
            ll1.Append(new Node(3));
            ll1.Append(new Node(4));

            LList llMerged = Program.Merge(ll1, ll2);
            bool conditions = llMerged.KthFromEnd(2) == 2 && llMerged.KthFromEnd(0) == 4;
            Assert.True(conditions);
        }

        //Test merging two linked lists of length 1
        [Fact]
        public void MergeTwoListsOfLengthOne()
        {
            LList ll1 = new LList(new Node(1));
            LList ll2 = new LList(new Node(2));
            LList llMerged = Program.Merge(ll1, ll2);
            bool conditions = llMerged.Head.Value == 1 && llMerged.Head.Next.Value == 2;
            Assert.True(conditions);
        }
    }
}
