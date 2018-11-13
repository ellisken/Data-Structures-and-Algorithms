using System;
using Tree.Classes;
using Xunit;
using TreeIntersection;
using System.Collections.Generic;

namespace TestIntersection
{
    public class UnitTest1
    {
        //Test where both trees are the same
        [Fact]
        public void TestTreesAreSame()
        {
            //Setup
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

            Assert.Equal(expected, Program.TreeIntersection(t1, t2));
        }

        //Test where one tree is null
        [Fact]
        public void TestOneTreeNull()
        {
            //Setup
            BinarySearchTree t1 = new BinarySearchTree();
            BinarySearchTree t2 = new BinarySearchTree();
            t1.Root = t1.Add(t1.Root, 1);
            t1.Root = t1.Add(t1.Root, 2);
            t1.Root = t1.Add(t1.Root, 3);

            //Create empty expected list
            List<int> expected = new List<int>();

            Assert.Equal(expected, Program.TreeIntersection(t1, t2));
        }

        //Test where trees are different
        [Fact]
        public void TestTreesAreDifferent()
        {
            //Setup
            BinarySearchTree t1 = new BinarySearchTree();
            BinarySearchTree t2 = new BinarySearchTree();
            t1.Root = t1.Add(t1.Root, 1);
            t1.Root = t1.Add(t1.Root, 2);
            t1.Root = t1.Add(t1.Root, 3);
            t1.Root = t1.Add(t1.Root, 9);
            t1.Root = t1.Add(t1.Root, 4);
            t1.Root = t1.Add(t1.Root, 19);

            t2.Root = t2.Add(t2.Root, 1);
            t2.Root = t2.Add(t2.Root, 3);
            t2.Root = t2.Add(t2.Root, 2);
            t2.Root = t2.Add(t2.Root, 10);
            t2.Root = t2.Add(t2.Root, 12);

            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(2);

            Assert.Equal(expected, Program.TreeIntersection(t1, t2));
        }

    }
}
