using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class HashTable
    {
        public Node[] Table { get; set; }
        public int Count { get; set; }
        public int Capacity { get; set; }

        public HashTable(int capacity)
        {
            Capacity = capacity;
            Count = 0;
            Table = new Node[capacity];
        }

        /// <summary>
        /// Adds a given key:value pair to the hashtable. If the key already exists,
        /// that keys value is simply updated.
        /// </summary>
        /// <param name="key">Key to add/update</param>
        /// <param name="value">Associated value</param>
        public void Add(string key, object value)
        {
            //Get the key's hash
            int keyHash = GetHash(key);
            //Search the table to see if the key already exists
            Node current = Table[keyHash];
            while(current != null)
            {
                //If so, update that key's value
                if(current.Key == key)
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }
            //Else, add a new link to the beginning of the bucket
            Node newEntry = new Node(key, value);
            newEntry.Next = Table[keyHash];
            Table[keyHash] = newEntry;
            Count++;
        }

        /// <summary>
        /// Determines whether a given key exists in the hashtable. If so, returns
        /// that key's value
        /// </summary>
        /// <param name="key">Key to search for</param>
        /// <returns>The key's value if the key exists, else returns null</returns>
        public object Find(string key)
        {
            //Get the hash of the key
            int keyHash = GetHash(key);
            //Traverse the bucket to find the key
            Node current = Table[keyHash];
            while(current != null)
            {
                if(current.Key == key)
                {
                    //Return the value
                    return current.Value;
                }
                current = current.Next;
            }
            //Otherwise, return null
            return null;
        }

        /// <summary>
        /// Determines whether a key exists in the hashtable
        /// </summary>
        /// <param name="key">Key to look for</param>
        /// <returns>True if the key is in the table, else returns false</returns>
        public bool Contains(string key)
        {        
            //Get the hash of the key
            int keyHash = GetHash(key);
            //Traverse the bucket to find the key
            Node current = Table[keyHash];
            while (current != null)
            {
                if (current.Key == key)
                {
                    //Return true
                    return true;
                }
                current = current.Next;
            }
            //Otherwise, return false
            return false;
        }

        public int GetHash(string key)
        {
            int hashedKey = 0;
            //Add each key character's ascii value
            //to the hashedKey
            for(int i=0; i < key.Length; i++)
            {
                hashedKey += key[i];
            }
            //Returns the hashedKey value modded by the table's capacity
            return hashedKey % Capacity;
        }
    }
}
