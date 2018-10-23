using System;
using StackAndQueue.Classes;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        Stack s1 = new Stack(null);
        Stack s2 = new Stack(null);

        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            s1.Push(node);
            Front = Rear = node;
        }

        public void Enqueue(Node node)
        {
            s1.Push(node);
            Rear = node;
        }

        public Node Dequeue()
        {
            Node currentNode;
            if (s1.Peek() == null) currentNode = null;
            else currentNode = s1.Pop();
            while(currentNode != null)
            {
                s2.Push(currentNode);
                if (s1.Peek() == null) currentNode = null;
                else currentNode = s1.Pop();
            }


            Node rearNode;
            if (s2.Peek() == null) rearNode = null;
            else rearNode = s2.Pop();

            if (s2.Peek() == null) currentNode = null;
            else currentNode = s2.Pop();
            Front = currentNode;
            while(currentNode != null)
            {
                s1.Push(currentNode);
                if (s2.Peek() == null) currentNode = null;
                else currentNode = s2.Pop();
            }

            return rearNode;
        }
    }
}
