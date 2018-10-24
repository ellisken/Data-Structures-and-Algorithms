using System;
using StackAndQueue.Classes;
using Xunit;

namespace TestStackAndQueue
{
    public class UnitTest1
    {
        //Test pushing a node onto your stack
        [Fact]
        public void PushNodeOntoStack()
        {
            Stack testStack = new Stack(new Node(1));
            testStack.Push(new Node(2));
            Assert.Equal(2, testStack.Peek().Value);
        }

        //Test popping a node off your stack
        [Fact]
        public void PopNodeOffStack()
        {
            Stack s = new Stack(new Node(1));
            Assert.Equal(1, s.Pop().Value);
        }

        //Peeking at the top node of your stack
        [Fact]
        public void PeekAtTopOfStack()
        {
            Stack testStack = new Stack(new Node(1));
            testStack.Push(new Node(2));
            testStack.Push(new Node(3));
            Assert.Equal(testStack.Top.Value, testStack.Peek().Value);
        }

        //Enqueue a node into your queue
        [Fact]
        public void EnqueueToNull()
        {
            Queue q = new Queue(null);
            q.Enqueue(new Node(1));
            Assert.True((int)q.Front.Value == 1 && (int)q.Rear.Value == 1);
        }

        [Fact]
        public void EnqueueANode()
        {
            Queue q = new Queue(new Node(1));
            q.Enqueue(new Node(2));
            Assert.Equal(2, q.Rear.Value);
        }

        //Dequeue a node off of your queue
        [Fact]
        public void DequeueANode()
        {
            Queue q = new Queue(new Node(1));
            q.Enqueue(new Node(2));
            q.Dequeue();
            Assert.Equal(2, q.Front.Value);
        }

        //Peek at the front of your queue.
        [Fact]
        public void PeekAtFront()
        {
            Queue q = new Queue(new Node(1));
            q.Enqueue(new Node(2));
            Assert.Equal(q.Front.Value, q.Peek().Value);
        }
    }
}
