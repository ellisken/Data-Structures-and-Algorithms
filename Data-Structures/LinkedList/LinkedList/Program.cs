using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList testLL = new LList(new Node(4));
            testLL.Append(new Node(21));
            Node newNode = new Node(5);
            testLL.AddBefore(newNode, 21);

            Console.WriteLine($"{testLL.Head.Value}");
        }
    }
}
