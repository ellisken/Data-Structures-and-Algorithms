using Hashtables.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find a repeated word:");
            string book = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Console.WriteLine($"Test book is: {book}");
            Console.WriteLine();
            Console.WriteLine("First duplicate word:");
            Console.WriteLine($"{RepeatedWord(book)}");
        }

        /// <summary>
        /// Determines if ther are any duplicate words. If duplicates exist, the 
        /// method returns the first duplicate word.
        /// </summary>
        /// <param name="book">The text to check</param>
        /// <returns>The first repeated word, else "No Duplicates"</returns>
        public static string RepeatedWord(string book)
        {
            HashTable words = new HashTable(100);
            char[] charsToTrim = { ',', '.', '?', '!' };
            //Get individual words
            string[] tokens = book.Split(" ");
            //Trim special chars and normalize
            for(int i=0; i < tokens.Length; i++)
            {
                tokens[i] = tokens[i].Trim(charsToTrim).ToLower();
            }

            //Process tokens
            for(int j=0; j < tokens.Length; j++)
            {
                //Check if word is already in dictionary, return word
                if (words.Contains(tokens[j]))
                {
                    return tokens[j];
                }
                //Else add token to words dictionary
                else
                {
                    if(tokens[j] != "") words.Add(tokens[j], true);
                }
            }
            return "No Duplicates";
        }
    }
}
