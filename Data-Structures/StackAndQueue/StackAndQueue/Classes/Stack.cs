using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public Stack(Node node)
        {
            Top = node;
        }

        //Peek returns the top of the stack
        public Node Peek()
        {
            return Top;
        }

        //Pop removes the top of the stack and returns it
        public Node Pop()
        {
            Node oldTopNode = Peek();
            //Reset Top to second from top ode
            Top = Top.Next;
            //Reset old top node's next to null before returning
            oldTopNode.Next = null;
            return oldTopNode;
        }

        //Push adds a node to the top of the stack
        public void Push(Node node)
        {
            //Sets old top node to new node's next
            node.Next = Top;
            //Sets new node to Top
            Top = node;
        }

    }
}
