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

            Console.WriteLine("List after reversal:");
            myList.Print();

        }


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


        public static void LinkedListReverseMoreEfficiently(LList list)
        {
            //Create pointers to track position
            Node current = list.Head, prev = null, next = null;

            list.Current = list.Head;
            while(list.Current != null)
            {
                //Get next link
                next = list.Current.Next;

                //Reverse current node's next ptr
                list.Current.Next = prev;

                //Advance pointers
                prev = list.Current;
                list.Current = list.Current.Next;
            }
            list.Head = prev;
        }
    }
}
