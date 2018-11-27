using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        public int VertexCount { get; set; }
        public List<Vertex> Vertices { get; set; }
        
        /// <summary>
        /// Creates a graph with unconnected nodes
        /// </summary>
        /// <param name="values">A list of values to give the graph nodes</param>
        public Graph(List<object> values)
        {
            //For each item in the list of values, create a Vertex and add it to the Vertices list
            foreach(object value in values)
            {
                Vertices.Add(new Vertex(value));
            }
        }

        public void AddEdge(object v1, object v2, int weight)
        {
            //Find the v1 in the vertex list by value
            Vertex v1Ref = Vertices.Find(x => x.Value == v1);
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




    }
} 
