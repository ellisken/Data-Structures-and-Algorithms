using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {   
        /// <summary>
        /// First node in the linked list
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Always points to current node in the list
        /// </summary>
        public Node Current { get; set; }

        public LList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Inserts a node at the beginning of the LL, O(1)
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

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

        /// <summary>
        /// Adds the new node before the node with the specified value
        /// </summary>
        /// <param name="newNode">New node to be inserted</param>
        /// <param name="valueOfExistingNode">Value of node to insert new node before</param>
        public void AddBefore(Node newNode, int valueOfExistingNode)
        {
            Current = Head;
            //Otherwise, look for the node with the given value
            //and insert the new node before it
            while(Current.Next != null)
            {
                if (Current.Next.Value == valueOfExistingNode)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    Current = newNode.Next;
                }
                else
                {
                    Current = Current.Next;
                }
            }
        }

        /// <summary>
        /// Adds the new node after the node with the specified value
        /// </summary>
        /// <param name="newNode">New node to be inserted</param>
        /// <param name="valueOfExistingNode">Value of node to insert new node after</param>
        public void AddAfter(Node newNode, int valueOfExistingNode)
        {
            Current = Head;
            while(Current != null)
            {
                if(Current.Value == valueOfExistingNode)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Returns the kth value from the end
        /// </summary>
        /// <param name="k">Represents kth value from end</param>
        /// <returns>Value of kth node from the end, else returns an exception</returns>
        public int KthFromEnd(int k)
        {
            int length = 0;
            Current = Head;
            
            while(Current != null)
            {
                length++;
                Current = Current.Next;
            }

            if(k > length - 1)
            {
                throw new Exception("Out of range");
            }

            Current = Head;
            for(int i=0; i < length - k - 1; i++)
            {
                Current = Current.Next;
            }
            return Current.Value;
        }
    }
}
