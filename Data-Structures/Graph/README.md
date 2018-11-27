# Undirected, Weighted Graph
This implementation creates a weighted, undirected graph that allows for a maximum of one connection between two nodes. 

## Challenge
Implement a weighted, undirected graph.

* Size() - returns the number of nodes in the graph
* GetNodes() - returns a list of nodes in the graph
* AddEdge(value1, value2, weight) - adds an edge between value1 and value2 with the given weight. For example, let value1 = "Seattle", value2 = "Denver"
, and weight = 10. An edge will be added to the graph between the Seattle and Denver nodes with weight 10.
* GetNeighbors(value) - returns a dictionary (hashmap) of all neighboring nodes where each value is the weight between the parent node and the neighboring node.

## Approach and Efficiency
* Size() O(1)
* GetNodes() O(1)
* AddEdge() O(1) on average, O(n) worst case
* GetNeighbors() O(1)
