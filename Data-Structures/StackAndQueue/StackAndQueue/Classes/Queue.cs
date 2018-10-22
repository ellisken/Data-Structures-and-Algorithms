using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        //Peek returns the Front node but does not remove it fron the queue
        public Node Peek()
        {
            return Front;
        }

        //Enqueue adds a node to the rear of the queue
        public void Enqueue(Node node)
        {
            Rear.Next = node; //Set new node to Rear.Next
            Rear = node; //New rear is the new node
        }

        //Dequeue removes the front node and returns it
        public Node Dequeue()
        {
            Node oldFront = Front; //Create a temp to point to the front
            Front = Front.Next; //Set old front to next in line
            oldFront.Next = null; //set old front's next to null to "clean up"
            return oldFront;
        }
    }
}
