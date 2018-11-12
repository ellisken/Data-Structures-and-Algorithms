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

        public void Add(string key, object value)
        {
            //Get the key's hash
            int keyHash = GetHash(key) % Capacity;
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

        public object Find(string key)
        {
            //Get the hash of the key
            int keyHash = GetHash(key) % Capacity;
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

        public bool Contains(string key)
        {        
            //Get the hash of the key
            int keyHash = GetHash(key) % Capacity;
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
            //Add key character's index+1 multiplied by the key character
            //to the hashedKey
            for(int i=0; i < key.Length; i++)
            {
                hashedKey += (i + 1) * key[i];
            }
            return hashedKey;
        }
    }
}
