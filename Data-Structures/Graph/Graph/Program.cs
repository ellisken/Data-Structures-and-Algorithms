using Graph.Classes;
using System;
using System.Collections.Generic;

namespace Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> cities = new List<object>();
            cities.Add("Seattle");
            //Set up the graph
            UndirectedGraph g = new UndirectedGraph(cities);
            Console.WriteLine($"{g.Size()}");
        }
    }
}
