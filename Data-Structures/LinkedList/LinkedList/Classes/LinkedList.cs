using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LinkedList
    {   
        /// <summary>
        /// First node in the linked list
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Always points to current node in the list
        /// </summary>
        public Node Current { get; set; }

        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Adds a node at the beginning of the LL, O(1)
        /// </summary>
        /// <param name="node"></param>
        public void Insert(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while(Current != null)
            {
                if (Current.Value == value) return true;
            }
            return false;
        }

        public void Print()
        {
            Current = Head;
            while(Current != null)
            {
                Console.WriteLine($"{Current.Value}-->");
                Current = Current.Next;
            }
        }
    }
}
