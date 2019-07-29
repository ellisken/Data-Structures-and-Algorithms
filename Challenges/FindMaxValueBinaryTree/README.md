# Find Maximum Value Binary Tree

## Challenge
Write a method that takes a binary tree as input and returns the maximum value in that tree

## Approach & Efficiency
* Time Complexity = O(n): We must process all n nodes of the tree
* Space Complexity = O(w): where w is the width of the tree. 

## Notes
The implemented solution does not match the whiteboard solution. The whiteboard solution below shows a method that
recursively compares a root node to its left and right node values. The iterative version implemented uses a queue to 
process the nodes. One is not necessarily better than the other. Consider a binary tree where each node has only one child, and every 
child in the tree is a left child. If the tree has more than one (root) node, then the height will always be greater than the width.

## Solution
![whiteboard-image](../../assets/find-maximum-value-binary-tree.jpg)
