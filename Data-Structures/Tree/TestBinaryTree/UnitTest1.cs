using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

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
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 6)]
        [InlineData (12, 6, 3)]
        public void TestPreorder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v1, v2, v3 };
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            t.PreOrder(t.Root, values);
            Assert.Equal(expected, values);
        }

        //Test BT Inorder 1 node, 3 different values
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(12, 6, 3)]
        public void TestInorder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v2, v1, v3 };
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            t.InOrder(t.Root, values);
            Assert.Equal(expected, values);
        }

        //Test BT Postorder 1 node, 3 different values
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(12, 6, 3)]
        public void TestPostorder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v2, v3, v1 };
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            t.PostOrder(t.Root, values);
            Assert.Equal(expected, values);
        }
    }
}
