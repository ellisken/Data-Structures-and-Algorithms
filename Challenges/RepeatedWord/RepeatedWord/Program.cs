using Hashtables.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string RepeatedWord(string book)
        {
            HashTable words = new HashTable(100);
            char[] charsToTrim = { ',', '.', '?', '!' };
            string[] tokens = book.Split(" ");
            for(int i=0; i < tokens.Length; i++)
            {
                tokens[i] = tokens[i].Trim(charsToTrim).ToLower();
            }

            for(int j=0; j < tokens.Length; j++)
            {
                if (words.Contains(tokens[j]))
                {
                    return tokens[j];
                }
                else
                {
                    words.Add(tokens[j], true);
                }
            }
            return "No Duplicates";
        }
    }
}
