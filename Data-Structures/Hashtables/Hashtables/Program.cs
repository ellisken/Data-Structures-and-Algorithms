using Hashtables.Classes;
using System;
using System.Collections.Generic;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtables!");
            Console.WriteLine("Creating a hashtable...");
            //Your main method should contain an instantiation of your Hashtable.
            HashTable ht = new HashTable(5);

            //Add items to your hashtable
            Console.WriteLine("Adding stuff to the hashtable...");
            Console.WriteLine("Adding the key 'hello' with the value 'world'.");
            ht.Add("hello", "world");
            Console.WriteLine("Adding the key 'foo' with the value 'bar'.");
            ht.Add("foo", "bar");
            Console.WriteLine("Adding the key 'what's' with the value 'up'.");
            ht.Add("what's", "up");
            Console.WriteLine();

            //Force a collision
            Console.WriteLine("Forcing a collision...");
            Console.WriteLine("Adding the key 'oof' with the value 'blah'.");
            ht.Add("oof", "blah");
            Console.WriteLine();

            //Prove that all keys added exist in the hashtable.
            List<string> keys = new List<string>();
            keys.Add("hello");
            keys.Add("foo");
            keys.Add("what's");
            keys.Add("oof");

            Console.WriteLine("Proving that each key exists in the hashtable...");
            foreach(string word in keys)
            {
                Console.WriteLine($"{word}:{ht.Find(word)}");
            }
        }
    }
}
