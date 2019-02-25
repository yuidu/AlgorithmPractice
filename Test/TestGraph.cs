using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestGraph
    {
        public static void Test()
        {
            var graph = new SparseGraph(9, false);
            graph.AddEdge(7,1);
            graph.AddEdge(7,4);
            graph.AddEdge(7,6);

            graph.AddEdge(6,5);
            graph.AddEdge(5,3);
            graph.AddEdge(5,2);
            graph.AddEdge(3,2);
            graph.AddEdge(2,8);
            graph.AddEdge(8,0);

            bool hasEdge = graph.HasEdge(5,2);
            if (hasEdge)
                Console.WriteLine("Has Edge");
            else 
                Console.WriteLine("Has no Edge");
            Console.WriteLine("Vertex number:  "+ graph.V() + " Edge number: " + graph.E());

            var traverseGraph = new TraverseGraph(graph);
            traverseGraph.Dfs(7);

            var GraphPath = new GraphPath(graph);
            GraphPath.GetPath(4,8);
            GraphPath.GetPath(1,0);
            GraphPath.GetPath(0,1);
        }
    }
}