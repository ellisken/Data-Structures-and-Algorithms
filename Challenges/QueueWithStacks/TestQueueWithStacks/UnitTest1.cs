using QueueWithStacks.Classes;
using Xunit;

namespace TestQueueWithStacks
{
    public class UnitTest1
    {
        //Test enqueue
        [Theory]
        [InlineData (1)]
        [InlineData(2)]
        [InlineData (3)]
        public void TestEnqueueSuccess(int newVal)
        {
            Queue q = new Queue(new StackAndQueue.Classes.Node(newVal));
            bool conditions = (int)q.Front.Value == newVal && (int)q.Rear.Value == newVal;
            Assert.True(conditions);
        }

        //Test dequeue
        [Fact]
        public void TestDequeue1()
        {
            Queue q = new Queue(new StackAndQueue.Classes.Node(1));
            q.Enqueue(new StackAndQueue.Classes.Node(2));
            q.Enqueue(new StackAndQueue.Classes.Node(3));
            q.Enqueue(new StackAndQueue.Classes.Node(4));
            Assert.Equal(1, q.Dequeue().Value);
        }

        [Fact]
        public void TestDequeue2()
        {
            Queue q = new Queue(new StackAndQueue.Classes.Node(2));
            q.Enqueue(new StackAndQueue.Classes.Node(3));
            q.Enqueue(new StackAndQueue.Classes.Node(4));
            q.Enqueue(new StackAndQueue.Classes.Node(5));
            Assert.Equal(2, q.Dequeue().Value);
        }

        [Fact]
        public void TestDequeue3()
        {
            Queue q = new Queue(new StackAndQueue.Classes.Node(2));
            Assert.Equal(2, q.Dequeue().Value);
        }
    }
}
