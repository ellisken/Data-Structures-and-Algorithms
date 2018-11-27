using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Vertex
    {
        public object Value { get; set; }
        public bool IsVisited { get; set; }
        public Dictionary<Vertex, int> AdjacentVertices { get; set; }
        public Vertex(object value)
        {
            Value = value;
            IsVisited = false;
            AdjacentVertices = new Dictionary<Vertex, int>();
        }
    }
}
