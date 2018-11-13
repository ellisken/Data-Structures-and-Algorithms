using Hashtables.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Intersection!");
            BinarySearchTree t1 = new BinarySearchTree();
            BinarySearchTree t2 = new BinarySearchTree();
            t1.Root = t1.Add(t1.Root, 1);
            t2.Root = t2.Add(t2.Root, 1);
            t1.Root = t1.Add(t1.Root, 2);
            t2.Root = t2.Add(t2.Root, 2);
            t1.Root = t1.Add(t1.Root, 3);
            t2.Root = t2.Add(t2.Root, 3);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);

            Console.WriteLine("The intersection of two identical trees is:");
            Console.WriteLine($"{string.Join(",", TreeIntersection(t1, t2))}");
        }

        /// <summary>
        /// Finds the intersection of two binary trees  
        /// </summary>
        /// <param name="t1">Binary tree 1</param>
        /// <param name="t2">Binary tree 2</param>
        /// <returns>A list of values representing the intersection of the two trees</returns>
        public static List<int> TreeIntersection(BinaryTree t1, BinaryTree t2)
        {
            //Create containers
            List<int> intersection = new List<int>();
            HashTable tree1Values = new HashTable(10);

            //Put values from tree 1 into HashTable
            Tree.Classes.Node currentNode = t1.Root;
            List<int> valuesInPreorder = new List<int>();
            t1.PreOrder(t1.Root, valuesInPreorder);
            foreach (int num in valuesInPreorder)
            {
                tree1Values.Add(num.ToString(), true);
            }

            //Compare values in tree 2
            valuesInPreorder.Clear();
            t2.PreOrder(t2.Root, valuesInPreorder);
            foreach (int num in valuesInPreorder)
            {
                if (tree1Values.Contains(num.ToString()))
                {
                    intersection.Add(num);
                }
            }
            return intersection;
        }
    }
}
