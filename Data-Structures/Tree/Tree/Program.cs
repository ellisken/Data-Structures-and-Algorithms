﻿using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary trees!");

            BinaryTree myTree = new BinaryTree(1);
            myTree.Root.Left = new Node(2);
            myTree.Root.Right = new Node(3);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);
            List<int> preOrder = new List<int>();
            List<int> inOrder = new List<int>();
            List<int> postOrder = new List<int>();

            Console.WriteLine("Pre-order DFS traversal order:");
            myTree.PreOrder(myTree.Root, preOrder);
            foreach(int val in preOrder)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
            Console.WriteLine("In-order DFS traversal order:");
            myTree.InOrder(myTree.Root, inOrder);
            foreach (int val in inOrder)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
            Console.WriteLine("Post-order DFS traversal order:");
            myTree.PostOrder(myTree.Root, postOrder);
            foreach (int val in postOrder)
            {
                Console.Write($"{val} ");
            }
        }
    }
}
