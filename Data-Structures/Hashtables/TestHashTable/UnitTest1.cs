using System;
using Xunit;
using Hashtables.Classes;

namespace TestHashTable
{
    public class UnitTest1
    {
        //Test insertion
        [Theory]
        [InlineData("TestKey", "TestValue")]
        [InlineData("Hello", 25)]
        [InlineData("foo", true)]
        public void TestInsertion(string key, object value)
        {
            HashTable ht = new HashTable(10);
            ht.Add(key, value);
            Assert.Equal(value, ht.Find(key));
        }

        //Test Add(update)
        [Fact]
        public void TestUpdate()
        {
            HashTable ht = new HashTable(5);
            ht.Add("hello", "world");
            ht.Add("hello", "WORLD!");
            Assert.Equal("WORLD!", ht.Find("hello"));
        }

        //Test Contains
        [Theory]
        [InlineData("TestKey", "TestValue")]
        [InlineData("Hello", 25)]
        [InlineData("foo", true)]
        public void TestContains(string key, object value)
        {
            HashTable ht = new HashTable(10);
            ht.Add(key, value);
            Assert.True(ht.Contains(key));
        }

        //Test Contains when key does not exist
        [Fact]
        public void TestContainsKeyNotFound()
        {
            HashTable ht = new HashTable(5);
            ht.Add("hello", "world");
            Assert.False(ht.Contains("foo"));
        }

        //Test Collisions 1
        [Fact]
        public void TestCollisions1()
        {
            HashTable ht = new HashTable(5);
            ht.Add("12", "world");
            ht.Add("21", "bar");
            Assert.True(ht.Contains("12") && ht.Contains("21"));
        }

        //Test Collisions 2
        [Fact]
        public void TestCollisions2()
        {
            HashTable ht = new HashTable(5);
            ht.Add("12", "world");
            ht.Add("21", "bar");
            Assert.True(ht.Find("12") !=  ht.Find("21"));
        }
    }
}
