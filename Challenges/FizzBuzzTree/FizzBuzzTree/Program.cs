using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Binary Tree:");
            Console.WriteLine("\n\nThe values in the tree (pre-order traversal): 3, 15, 5, 7, 9, 20");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = bst.Add(bst.Root, 3);
            bst.Root = bst.Add(bst.Root, 15);
            bst.Root = bst.Add(bst.Root, 5);
            bst.Root = bst.Add(bst.Root, 7);
            bst.Root = bst.Add(bst.Root, 9);
            bst.Root = bst.Add(bst.Root, 20);
            Console.WriteLine("\nNow calling FizzBuzzTree(), which traverses the tree in pre-order:");
            FizzBuzzTree(bst);
        }

        /// <summary>
        /// Calls PreOrderFizzBuzz on the given tree's root
        /// </summary>
        /// <param name="tree">Tree for FizzBuzz</param>
        static void FizzBuzzTree(BinaryTree tree)
        {
            PreOrderFizzBuzz(tree.Root);
        }

        /// <summary>
        /// Recursively write Fizz (if a node's value is divisible by 3), Buzz
        /// (if a node's value is divisible by 5), or FizzBuzz (if the value is 
        /// divisible by both 3 and 5) to the console. Otherwise, it writes the node's value to the console
        /// </summary>
        /// <param name="root">The root of the tree to traverse</param>
        static void PreOrderFizzBuzz(Node root)
        {
            if (root.Value % 15 == 0) Console.WriteLine("FizzBuzz");
            else if (root.Value % 3 == 0) Console.WriteLine("Fizz");
            else if (root.Value % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(root.Value);
            if (root.Left != null) PreOrderFizzBuzz(root.Left);
            if (root.Right != null) PreOrderFizzBuzz(root.Right);
        }
    }
}
