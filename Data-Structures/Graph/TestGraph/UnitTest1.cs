using System;
using Xunit;
using Graph.Classes;
using System.Collections.Generic;

namespace TestGraph
{
    public class UnitTest1
    {
        //Test AddEdge()
        [Theory]
        [InlineData("Seattle", "LA", 10)]
        [InlineData("Seattle", "Denver", 2)]
        [InlineData("Denver", "LA", 5)]
        public void TestAddEdge(object v1, object v2, int weight)
        {
            List<object> cities = new List<object>()
            {
                "Seattle",
                "LA",
                "Denver"
            };
            //Set up the graph
            UndirectedGraph g = new UndirectedGraph(cities);
            //Add edge
            g.AddEdge(v1, v2, weight);
            //Assert success - that v1 is in the adjacency list of v2 and vice versa
            Dictionary<Vertex, int> v1Neighbors = g.GetNeighbors(v1);
            Dictionary<Vertex, int> v2Neighbors = g.GetNeighbors(v2);
            Assert.True(v1Neighbors.ContainsValue(weight) && v2Neighbors.ContainsValue(weight));
        }

        //Test GetNeighbors()
        [Theory]
        [InlineData(5, 1)]
        [InlineData(-4, 10)]
        [InlineData(100, -1)]
        public void TestGetNeighbors(int weight1, int weight2)
        {
            List<object> cities = new List<object>()
            {
                "Seattle",
                "LA",
                "Denver"
            };
            //Set up the graph
            UndirectedGraph g = new UndirectedGraph(cities);
            //Add edge
            g.AddEdge(cities[0], cities[1], weight1);
            g.AddEdge(cities[2], cities[0], weight2);

            Dictionary<Vertex, int> seattleNeighbors = g.GetNeighbors("Seattle");
            Assert.True(seattleNeighbors.ContainsValue(weight1) && seattleNeighbors.ContainsValue(weight2));
        }
    }
}
