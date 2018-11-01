using System;
using System.Collections.Generic;
using Tree.Classes;

namespace BreadthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Breadth-first Search:");
            BinaryTree t = new BinaryTree(1);
            t.Root.Left = new Node(2);
            t.Root.Right = new Node(3);
            t.Root.Left.Left = new Node(4);
            t.Root.Left.Right = new Node(5);
            t.Root.Right.Left = new Node(6);

            BreadthFirst(t);
        }
        
        /// <summary>
        /// Conducts a level-order (BFS) traversal of a binary tree
        /// and prints each node value
        /// </summary>
        /// <param name="tree">The binary tree to be traversed</param>
        static void BreadthFirst(BinaryTree tree)
        {
            Queue<Node> q = new Queue<Node>();

            //Empty tree? Return
            if (tree.Root == null) return;

            q.Enqueue(tree.Root);

            while(q.Count != 0)
            {
                Node currentNode = q.Peek();
                Console.WriteLine($"{currentNode.Value}");
                if (currentNode.Left != null)
                    q.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    q.Enqueue(currentNode.Right);
                q.Dequeue();
            }
        }
    }
}
