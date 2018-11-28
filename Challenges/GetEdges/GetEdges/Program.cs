using Graph.Classes;
using System;
using System.Collections.Generic;

namespace GetEdges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trip Itinerary");
        }

        static Tuple<bool, int> GetEdge(UndirectedGraph g, string[] cities)
        {
            int totalCost = 0;
            //Create default answer tuple
            Tuple<bool, int> answer = new Tuple<bool, int>( false, 0 );

            for(int i=0; i < cities.Length - 1; i++)
            {
                //Get neighbors
                Dictionary<Vertex, int> neighbors = g.GetNeighbors(cities[i]);
                if (neighbors.ContainsKey(cities[i + 1]))
                {

                }
            }
        }
    }
}
