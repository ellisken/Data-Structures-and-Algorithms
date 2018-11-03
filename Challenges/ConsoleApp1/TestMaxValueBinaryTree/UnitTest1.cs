using System;
using Xunit;
using Tree.Classes;
using FindMaxBinaryTree;



namespace TestMaxValueBinaryTree
{
    public class UnitTest1
    {
        //Test max value only positive ints
        [Fact]
        public void TestMaxValuePositiveValues()
        {
            BinaryTree t = new BinaryTree();
            t.Root = new Node(3);
            t.Root.Left = new Node(1);
            t.Root.Right = new Node(15);
            t.Root.Left.Left = new Node(31);

            Assert.Equal(31, Program.FindMaxValue(t));
        }

        //Test max value pos and neg ints
        [Fact]
        public void TestMaxValuePositiveNegativeValues()
        {
            BinaryTree t = new BinaryTree();
            t.Root = new Node(3);
            t.Root.Left = new Node(-1);
            t.Root.Right = new Node(15);
            t.Root.Left.Left = new Node(-31);

            Assert.Equal(15, Program.FindMaxValue(t));
        }

        //Test max value empty tree
        [Fact]
        public void TestMaxEmptyTree()
        {
            BinaryTree t = new BinaryTree();
            Assert.Equal(int.MinValue, Program.FindMaxValue(t));
        }
    }
}
