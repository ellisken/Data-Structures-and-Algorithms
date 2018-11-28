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
            Dictionary<string, int> v1Neighbors = g.GetNeighbors(v1);
            Dictionary<string, int> v2Neighbors = g.GetNeighbors(v2);
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

            Dictionary<string, int> seattleNeighbors = g.GetNeighbors("Seattle");
            Assert.True(seattleNeighbors.ContainsValue(weight1) && seattleNeighbors.ContainsValue(weight2));
        }


        //Test GetNodes
        [Theory]
        [InlineData("Seattle", "LA", "Denver")]
        [InlineData("Portland", "Salt Lake", "New York")]
        [InlineData("Atlanta", "San Diego", "Boston")]
        public void TestGetNodes(string c1, string c2, string c3)
        {
            List<object> cities = new List<object>();
            cities.Add(c1);
            cities.Add(c2);
            cities.Add(c3);
            UndirectedGraph g = new UndirectedGraph(cities);
            List<Vertex> nodes = g.GetNodes();

            Assert.True(cities[0] == nodes[0].Value && cities[1] == nodes[1].Value && cities[2] == nodes[2].Value);
        }

        //Test Size
        [Fact]
        public void TestSize0()
        {
            List<object> cities = new List<object>();
            UndirectedGraph g = new UndirectedGraph(cities);
            Assert.Equal(0, g.Size());
        }

        [Fact]
        public void TestSize1()
        {
            List<object> cities = new List<object>();
            cities.Add("Seattle");
            UndirectedGraph g = new UndirectedGraph(cities);
            Assert.Equal(1, g.Size());
        }

        [Fact]
        public void TestSize2()
        {
            List<object> cities = new List<object>();
            cities.Add("Seattle");
            cities.Add("San Francisco");
            UndirectedGraph g = new UndirectedGraph(cities);
            Assert.Equal(2, g.Size());
        }
    }
}
