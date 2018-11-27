using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        public int VertexCount { get; set; }
        public List<Vertex> Vertices { get; set; }
        
        public Graph(List<object> values)
        {
            //For each item in the list of values, create a Vertex and add it to the Vertices list
            foreach(object value in values)
            {
                Vertices.Add(new Vertex(value));
            }
        }
    }
} 
