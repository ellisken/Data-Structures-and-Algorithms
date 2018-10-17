using LinkedList.Classes;
using System;


namespace LLKthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates the implementation of getting\n the Kth value from the end of a linked list.");
            
            //Create new linked list
            LList ll = new LList(new Node(1));
            ll.Append(new Node(2));
            ll.Append(new Node(3));
            ll.Append(new Node(4));
            ll.Append(new Node(5));
            ll.Append(new Node(6));

            //Show values
            Console.WriteLine("The linked list has the following values: ");
            ll.Print();

            int kthFromEnd = -1;
            try
            {
                kthFromEnd = GetKthFromEndLL(ll, 2);
                Console.WriteLine($"The 2nd value from the end is {kthFromEnd}");
            }
            catch
            {
                Console.WriteLine("Exception received - this means that k was out of range");
            }
        }

        static int GetKthFromEndLL(LList ll, int k)
        {
            try
            {
                int answer = ll.KthFromEnd(k);
                return answer;
            }
            catch
            {
                throw;
            }
        }
    }
}
