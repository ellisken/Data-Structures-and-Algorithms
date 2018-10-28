using System;
using System.Collections.Generic;
using System.Text;

namespace TestBinaryTree.Classes
{
    class BinaryTree
    {
        Node root;

        /// <summary>
        /// Default contructor that creates an empty tree
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Creates a new tree with a given root value
        /// </summary>
        /// <param name="value"></param>
        public BinaryTree(int value)
        {
            root = new Node(value);
        }
    }
}
