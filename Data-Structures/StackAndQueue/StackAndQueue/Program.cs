using StackAndQueue.Classes;
using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Demo:");
            //Create nodes
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            //Stack
            Stack myStack = new Stack(n1);
            myStack.Push(n2);
            myStack.Push(n3);
            myStack.Push(n4);
            myStack.Push(n5);
            Console.WriteLine($"Peeking at the top of the stack: {myStack.Peek().Value}");
            Console.WriteLine("Popping the top off the stack...");
            myStack.Pop();
            Console.WriteLine($"Peeking at the new top of the stack: {myStack.Peek().Value}");
            Console.WriteLine("Pushing 6 onto the stack...");
            myStack.Push(new Node(6));
            Console.WriteLine($"Peeking at the top of the stack again: {myStack.Peek().Value}");

            Console.WriteLine("\n\n================================\n\n");
            //Queue
            Queue myQueue = new Queue(n1);
            myQueue.Enqueue(n2);
            myQueue.Enqueue(n3);
            myQueue.Enqueue(n4);
            myQueue.Enqueue(n5);

            Console.WriteLine($"Peeking at the fron of the queue: {myQueue.Peek().Value}");
            Console.WriteLine("Dequeuing...");
            myQueue.Dequeue();
            Console.WriteLine($"Peeking at the new front of the queue: {myQueue.Peek().Value}");
            Console.WriteLine("Enqueueing 6...");
            myQueue.Enqueue(new Node(6));
            Console.WriteLine($"Peeking at the front of the queue again: {myQueue.Peek().Value}");

        }
    }
}
