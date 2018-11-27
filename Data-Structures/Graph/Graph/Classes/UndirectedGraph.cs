using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class UndirectedGraph
    {
        public List<Vertex> Vertices { get; set; }

        public UndirectedGraph()
        {

        }
        
        /// <summary>
        /// Creates a graph with unconnected nodes. DOES NOT HANDLE DUPLICATE NODE VALUES.
        /// </summary>
        /// <param name="values">A list of values to give the graph nodes</param>
        public UndirectedGraph(List<object> values)
        {
            //For each item in the list of values, create a Vertex and add it to the Vertices list
            Vertices = new List<Vertex>();
            foreach(object value in values)
            {  
                Vertices.Add(new Vertex(value));
            }
        }

        /// <summary>
        /// Adds an edge between the two vertices (denoted by value). If 
        /// either vertex does not exist, a new vertex is created with the given value and
        /// added to the graph's list of vertices. This assumes the graph is not directed.
        /// </summary>
        /// <param name="v1">Value of first vertex</param>
        /// <param name="v2">Value of second vertex</param>
        /// <param name="weight">Weight of edge between vertices</param>
        public void AddEdge(object v1, object v2, int weight)
        {
            //Find the v1 in the vertex list by value
            Vertex v1Ref = Vertices.Find(x => x.Value == (object)v1);
            if(v1Ref == null)
            {
                v1Ref = new Vertex(v1);
                Vertices.Add(v1Ref);
            }
            Vertex v2Ref = Vertices.Find(x => x.Value == v2);
            if(v2Ref == null)
            {
                v2Ref = new Vertex(v2);
                Vertices.Add(v2Ref);
            }

            //Add key:value pair from v1 to v2 with given weight, and vice versa
            v1Ref.AdjacentVertices.Add(v2Ref, weight);
            v2Ref.AdjacentVertices.Add(v1Ref, weight);
        }

        /// <summary>
        /// Returns a list of the graph's vertices
        /// </summary>
        /// <returns>A list of the graph's vertices</returns>
        public List<Vertex> GetNodes()
        {
            return Vertices;
        }

        /// <summary>
        /// Returns the number of vertices in the graph
        /// </summary>
        /// <returns>The vertex count for the graph</returns>
        public int Size()
        {
            return Vertices.Count;
        }

        /// <summary>
        /// Returns a dictionary of a vertex's neighbors where each key is another vertex,
        /// and each value is the edge weight between the two vertices
        /// </summary>
        /// <param name="value">Vertex value</param>
        /// <returns>Dictionary of neighboring vertices with edge weights as values</returns>
        public Dictionary<Vertex, int> GetNeighbors(object value)
        {
            //Find the node in the list of vertices with the given value
            Vertex vertexRef = Vertices.Find(x => x.Value == value);
            //If the node is not in the graph, return null
            if (vertexRef == null)
            {
                return null;
            }
            //Else, return the node's list of adjacent vertices
            return vertexRef.AdjacentVertices;
        }

    }
} 
