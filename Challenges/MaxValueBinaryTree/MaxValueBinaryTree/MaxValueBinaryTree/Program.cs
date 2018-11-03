using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FindMaxBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum value of a binary tree.");
        }

        public static int FindMaxValue(BinaryTree tree)
        {
            Queue<Node> q = new Queue<Node>();
            int max = int.MinValue;

            if (tree.Root == null) return max;
            else
            {
                q.Enqueue(tree.Root);
                while (q.Count > 0)
                {
                    Node current = q.Dequeue();
                    if (current.Value > max) max = current.Value;
                    if (current.Left != null) q.Enqueue(current.Left);
                    if (current.Right != null) q.Enqueue(current.Right);
                }
            }
            return max;
        }
    }
}
