using LinkedList.Classes;
using System;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of zipper merge for two linked lists:\n\n");
            
            //Create new linked list
            LList ll1 = new LList(new Node(1));
            LList ll2 = new LList(new Node(5));
            ll1.Append(new Node(3));
            ll1.Append(new Node(2));
            ll2.Append(new Node(9));
            ll2.Append(new Node(4));


            //Show values
            Console.WriteLine("The first linked list has the following values: ");
            ll1.Print();
            Console.WriteLine("\n\nThe second linked list has the following values: ");
            ll2.Print();

            LList llMerged = Merge(ll1, ll2);
            Console.WriteLine("\n\nThe merged linked list: ");
            llMerged.Print();
        }


        public static LList Merge(LList l1, LList l2)
        {
            Node newListHead = new Node();
            Node tail = newListHead; //Reference ptr to tail, starts at head

            //Reset start of both lists
            l1.Current = l1.Head;
            l2.Current = l2.Head;

            while (true)
            {
                //If l1 has no more nodes, rest of newList is l2
                if(l1.Current == null)
                {
                    tail.Next = l2.Current;
                    break;
                }
                //If l2 has no more nodes, rest of newList is l1
                else if(l2.Current == null)
                {
                    tail.Next = l1.Current;
                    break;
                }
                //Otherwise, move tail down l1 and l2, alternating
                else
                {
                    tail.Next = l1.Current;
                    tail = l1.Current;
                    l1.Current = l1.Current.Next;
                    tail.Next = l2.Current;
                    tail = l2.Current;
                    l2.Current = l2.Current.Next;
                }
            }
            //Create a new linked list where the head is set as the first
            //node in the merged list that has a value (i.e., skip dummy newListHead node)
            LList newList = new LList(newListHead.Next);
            return newList;
        }
    }
}
