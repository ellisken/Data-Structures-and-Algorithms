using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Default contructor that creates an empty tree
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Creates a new tree with a given root value
        /// </summary>
        /// <param name="value">Root value</param>
        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        /// <summary>
        /// Returns a list of values in pre-order for a binary tree
        /// </summary>
        /// <param name="root">The binary tree's root</param>
        /// <param name="valuesInPreOrder">An empty list to add values to</param>
        public void PreOrder(Node root, List<int> valuesInPreOrder)
        {
            //Base case: if node is null, return
            if (root == null) return;
            //Else add the value to the list and call recursively on left and right nodes
            valuesInPreOrder.Add(root.Value);
            PreOrder(root.Left, valuesInPreOrder);
            PreOrder(root.Right, valuesInPreOrder);
        }

        /// <summary>
        /// Returns a list of values in order for a binary tree
        /// </summary>
        /// <param name="root">The binary tree's root</param>
        /// <param name="valuesInOrder">An empty list to add values to</param>
        public void InOrder(Node root, List<int> valuesInOrder)
        {
            if (root == null) return;
            InOrder(root.Left, valuesInOrder);
            valuesInOrder.Add(root.Value);
            InOrder(root.Right, valuesInOrder);
        }


        /// <summary>
        /// Returns a list of values in post-order for a binary tree
        /// </summary>
        /// <param name="root">The binary tree's root</param>
        /// <param name="valuesInPostOrder">An empty list to add values to</param>
        public void PostOrder(Node root, List<int> valuesInPostOrder)
        {
            if (root == null) return;
            PostOrder(root.Left, valuesInPostOrder);
            PostOrder(root.Right, valuesInPostOrder);
            valuesInPostOrder.Add(root.Value);
        }
    }
}
