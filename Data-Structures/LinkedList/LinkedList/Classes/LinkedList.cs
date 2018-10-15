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
        /// Inserts a node at the beginning of the LL, O(1)
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Insert(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Determines if a value is in the LL
        /// </summary>
        /// <param name="value">Target value</param>
        /// <returns>True if in the LL, else false</returns>
      

        /// <summary>
        /// Prints out all values in the linked list
        /// </summary>
        public void Print()
        {
            Current = Head;
            while(Current != null)
            {
                Console.WriteLine($"{Current.Value}-->");
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Adds a node to the end of the LL. O(n).
        /// </summary>
        /// <param name="node">Node to be appended</param>
        public void Append(Node node)
        {
            Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if(Current.Value == existingNode.Value)
            {
                Insert(newNode);
            }
            while(Current.Next != null)
            {
                if(Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                }
                Current = Current.Next;
            }
        }
    }
}
