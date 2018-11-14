using RepeatedWord;
using System;
using Xunit;

namespace TestRepeatedWord
{
    public class UnitTest1
    {
        //Test no repeated words
        [Fact]
        public void TestNoRepeatedWords()
        {
            string book = "There are no repeated words in this book...";
            Assert.Equal("No Duplicates", Program.RepeatedWord(book));
        }

        //Test one repeated word
        [Fact]
        public void TestRepeatedWord()
        {
            string book = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Assert.Equal("summer", Program.RepeatedWord(book));
        }

        //Test multiple repeated words
        [Fact]
        public void TestRepeatedWords()
        {
            string book = "a a book book is good is so very good";
            Assert.Equal("a", Program.RepeatedWord(book));
        }
    }
}
