# Hash Table (with buckets)
This implementation creates a hash table from an array of singly-linked lists. Any collisions are handled by creating a new node for the
key's hash value (i.e., the index of the table where the key:value pair should be stored) and adding that new node as the head
of the list at that index.

## Challenge
Implement a Hashtable with

* Add(key, value) - void return
* Find(key) - returns the value from key/value pair
* Contains(key) - returns bool
* GetHash(key) - returns array index

## Approach and Efficiency
* Add() O(1)
* Find() O(1) on average, O(n) worst case
* Contains() O(1) on average, O(n) worst case
* GetHash() O(1)
