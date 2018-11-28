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
            Console.WriteLine("I want to go from Seattle to Denver to LA...");
            Console.WriteLine("Seattle to Denver costs $300 and Denver to LA costs $200");
            //Create itinerary array
            string[] cities = { "Seattle", "Denver", "LA"};
            List<object> nodes = new List<object>()
            {
                "Seattle",
                "Denver",
                "LA"
            };

            //Create graph
            UndirectedGraph g = new UndirectedGraph(nodes);

            //Add edges
            g.AddEdge("Seattle", "Denver", 300);
            g.AddEdge("Denver", "LA", 200);

            //Run GetEdge
            Console.WriteLine("Running GetEdge...");
            Tuple<bool, int> result = GetEdge(g, cities);

            //Check that it worked
            Console.WriteLine("Expected: true, $500");
            Console.WriteLine($"Result: {result.Item1}, ${result.Item2}");
        }

        public static Tuple<bool, int> GetEdge(UndirectedGraph g, string[] cities)
        {
            int totalCost = 0;
            //Create default answer tuple
            Tuple<bool, int> noTrip = new Tuple<bool, int>( false, 0 );

            for(int i=0; i < cities.Length - 1; i++)
            {
                //Get neighbors
                Dictionary<string, int> neighbors = g.GetNeighbors(cities[i]);
                if (neighbors.ContainsKey(cities[i + 1]))
                {
                    totalCost += neighbors[cities[i + 1]];
                }
                else
                {
                    return noTrip;
                }
            }
            Tuple<bool, int> trip = new Tuple<bool, int>(true, totalCost);
            return trip;
        }
    }
}
