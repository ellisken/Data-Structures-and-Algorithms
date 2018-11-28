using GetEdges;
using Graph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGetEdge
{
    public class UnitTest1
    {
        //Test GetEdge only one city
        [Fact]
        public void Test1City()
        {
            List<object> nodes = new List<object>()
            {
                "Seattle"
            };

            string[] cities = { "Seattle"};

            //Create graph
            UndirectedGraph g = new UndirectedGraph(nodes);
            Tuple<bool, int> result = Program.GetEdge(g, cities);
            Assert.True(result.Item1 == true && result.Item2 == 0);
        }

        //Test path exists
        [Fact]
        public void TestPathExists()
        {
            List<object> nodes = new List<object>()
            {
                "Seattle",
                "Denver",
                "LA"
            };

            string[] cities = { "Seattle", "Denver", "LA" };

            //Create graph
            UndirectedGraph g = new UndirectedGraph(nodes);
            g.AddEdge("Seattle", "Denver", 300);
            g.AddEdge("Denver", "LA", 200);
            Tuple<bool, int> result = Program.GetEdge(g, cities);
            Assert.True(result.Item1 == true && result.Item2 == 500);
        }

        //Test path does not exist
        [Fact]
        public void TestPathDoesNotExist()
        {
            List<object> nodes = new List<object>()
            {
                "Seattle",
                "Denver",
                "LA"
            };

            string[] cities = { "Seattle", "Denver", "LA" };

            //Create graph
            UndirectedGraph g = new UndirectedGraph(nodes);
            g.AddEdge("Seattle", "Denver", 300);
            g.AddEdge("Seattle", "LA", 200);
            Tuple<bool, int> result = Program.GetEdge(g, cities);
            Assert.True(result.Item1 == false && result.Item2 == 0);
        }
    }
}
