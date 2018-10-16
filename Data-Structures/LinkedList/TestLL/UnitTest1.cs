using System;
using Xunit;
using LinkedList.Classes;

namespace TestLL
{
    public class UnitTest1
    {
        //Test Add() works correctly
        [Theory]
        [InlineData (5)]
        [InlineData (22)]
        [InlineData (-1)]
        public void TestAddToBeginningOfList(int value)
        {
            LList testLL = new LList(new Node(6));
            Node newNode = new Node(value);
            testLL.Add(newNode);
            Assert.Equal(value, testLL.Head.Value);
        }

        //Test Append works correctly
        [Theory]
        [InlineData(5)]
        [InlineData(22)]
        [InlineData(-1)]
        public void TestAppendWords(int value)
        {
            LList testLL = new LList(new Node(6));
            Node newNode = new Node(value);
            testLL.Append(newNode);
            //Node secondToLastNode = testLL.Find(6);
            //Test that last node's value is equal to the just-appended node's value
            Assert.Equal(testLL.Head.Next.Value, value);
        }

        //Test AddBefore works
        [Theory]
        [InlineData(5, 6)]
        [InlineData(22, 32)]
        [InlineData(-1, -3)]
        public void TestAddBefore(int existingValue, int newValue)
        {
            LList testLL = new LList(new Node(21));
            testLL.Append(new Node(existingValue));
            Node newNode = new Node(newValue);
            testLL.AddBefore(newNode, existingValue);

            Assert.Equal(newValue, testLL.Head.Next.Value);
        }

        //Test AddAfter works
        [Theory]
        [InlineData(5, 6)]
        [InlineData(22, 32)]
        [InlineData(-1, -3)]
        public void TestAddAfter(int existingValue, int newValue)
        {
            LList testLL = new LList(new Node(existingValue));
            testLL.Append(new Node(21));
            Node newNode = new Node(newValue);
            testLL.AddAfter(newNode, existingValue);

            Assert.Equal(newValue, testLL.Head.Next.Value);
        }
    }
}
