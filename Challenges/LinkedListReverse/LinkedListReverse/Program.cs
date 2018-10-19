using System;
using LinkedList.Classes;

namespace LinkedListReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList myList = new LList(new Node(1));
        }


        public static void LinkedListReverse(LList list)
        {
            //Create pointers to track position
            Node current = list.Head, prev = null, next = null;

            list.Current = list.Head;
            while(list.Current != null)
            {
                next = list.Current.Next;
                list.Current.Next = prev;
                prev = list.Current;
                list.Current = list.Current.Next;
            }
            list.Head = prev;
        }
    }
}
