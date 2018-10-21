# Linked List Reverse

## Challenge
Write a method to reverse a singly linked list

## Approach & Efficiency
This solution includes two methods: LinkedListReverse() and LinkedListReverseInPlace(). The first method reverses a linked list with help from
a stack. It starts by adding all values in-order to the stack, then pops each value off the stack (which is in reverse order from the original
list) and reassigns each node's value starting from the head. The second method reverses the list in place using 2 helper pointers (since
the implementation of LinkedList used here tracks the current node already).

* Time Complexity (LinkedListReverse & LinkedListReverseInPlace) = O(n): We must traverse all n nodes of the list
* Space Complexity (LinkedListReverse) = O(n): We create a Stack of length n.
* Space Complexity (LinkedListReverseInPlace) = O(1).
