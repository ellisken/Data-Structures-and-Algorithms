using System;
using System.Collections.Generic;
using LinkedList.Classes;

namespace LinkedListReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList myList = new LList(new Node(1));
            myList.Append(new Node(2));
            myList.Append(new Node(3));
            myList.Append(new Node(4));

            Console.WriteLine("List before reversal:");
            myList.Print();

            LinkedListReverse(myList);

            Console.WriteLine("List after less-efficient reversal:");
            myList.Print();
            LinkedListReverseInPlace(myList);

            Console.WriteLine("List after efficient reversal:");
            myList.Print();
        }

        /// <summary>
        /// Reverses a linked list with space O(n)
        /// </summary>
        /// <param name="list">Linked list to reverse</param>
        public static void LinkedListReverse(LList list)
        {
            //Create stack to store values
            Stack<int> values = new Stack<int>();

            list.Current = list.Head;

            //Get values
            while(list.Current != null)
            {
                values.Push(list.Current.Value);
                list.Current = list.Current.Next;
            }

            //Reassign list values
            list.Current = list.Head;
            while(list.Current != null)
            {
                int val = values.Pop();
                list.Current.Value = val;
                list.Current = list.Current.Next;
            }
        }

        /// <summary>
        /// Reverses a linked list with space O(1)
        /// </summary>
        /// <param name="list">Linked list to reverse</param>
        public static void LinkedListReverseInPlace(LList list)
        {
            //Create pointers to track position
            list.Current = list.Head;
            Node prev = null, next = null;

            while(list.Current != null)
            {
                //Get next link
                next = list.Current.Next;

                //Reverse current node's next ptr
                list.Current.Next = prev;

                //Advance pointers
                prev = list.Current;
                list.Current = next;
            }
            list.Head = prev;
        }
    }
}
