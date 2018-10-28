using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// Inserts a new value into a BST in the proper place
        /// </summary>
        /// <param name="root">The BST's root</param>
        /// <param name="value">Value to be inserted</param>
        public void Add(Node root, int value)
        {
            //Base case, the tree is empty or we've reached an empty leaf
            if (root == null)
            {
                root.Value = value;
                return;
            }
            //If not empty, compare new value to root
            if(value < root.Value)
            {
                Add(root.Left, value);
            }
            else Add(root.Right, value);
        }

        /// <summary>
        /// Searches a binary search tree for a value and returns the node with the specified value.
        /// </summary>
        /// <param name="root">The BST's root</param>
        /// <param name="value">Value to be found</param>
        /// <returns>The node with the value, else null (i.e., not found)</returns>
        public Node Search(Node root, int value)
        {
            //Base cases: the root is null or the root has the searched for value
            if(root == null || root.Value == value)
            {
                return root;
            }
            //Else, if the value is less than the root's value, search the left side of the tree recursively
            if (value < root.Value) return Search(root.Left, value);
            //Else search the right side of the tree recursively
            return Search(root.Right, value);
        }
    }
}
