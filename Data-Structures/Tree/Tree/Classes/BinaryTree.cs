using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree
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

        public void PreOrder(Node root, List<int> valuesInPreOrder)
        {
            //Base case: if node is null, return
            if (root == null) return;
            //Else add the value to the list and call recursively on left and right nodes
            valuesInPreOrder.Add(root.Value);
            PreOrder(root.Left, valuesInPreOrder);
            PreOrder(root.Right, valuesInPreOrder);
        }

        public void InOrder(Node root, List<int> valuesInOrder)
        {
            if (root == null) return;
            InOrder(root.Left, valuesInOrder);
            valuesInOrder.Add(root.Value);
            InOrder(root.Right, valuesInOrder);
        }
    }
}
