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
