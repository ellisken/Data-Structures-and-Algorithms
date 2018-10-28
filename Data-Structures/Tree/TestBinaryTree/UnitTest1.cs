using System;
using Xunit;
using Tree.Classes;


namespace TestBinaryTree
{
    public class UnitTest1
    {
        //Test BST add 1 value
        [Fact]
        public void Add1BST()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = bst.Add(bst.Root, 1);

            Assert.Equal(1, bst.Root.Value);
        }

        //Test BST add 2 values
        [Fact]
        public void Add2Bst()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 2);
            Assert.True(bst.Root.Value == 1 && bst.Root.Right.Value == 2);
        }

        //Test BST add 3 values where one is the same
        [Fact]
        public void Add3Bst()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 2);
            Assert.True(bst.Root.Value == 1 && bst.Root.Right.Value == 2 && bst.Root.Left == null);
        }

        //Test BST Search exists
        [Fact]
        public void BSTSearchValueExists()
        {
            int[] values = { 6, 1, 4, 20, 10 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }
            Assert.Equal(6, bst.Search(bst.Root, 6).Value);
        }

        //Test BST Search value == root
        [Fact]
        public void BSTSearchValueIsRoot()
        {
            int[] values = { 6 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }
            Assert.Equal(6, bst.Search(bst.Root, 6).Value);
        }

        //Test BST Search does not exist
        [Fact]
        public void BSTSearchValueDoesNotExist()
        {
            int[] values = { 6, 1, 4, 20, 10 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }
            Assert.Null(bst.Search(bst.Root, 5));
        }
        //Test BT Preorder 1 node, 3 different values
        //Test BT Inorder 1 node, 3 different values
        //Test BT Postorder 1 node, 3 different values
    }
}
