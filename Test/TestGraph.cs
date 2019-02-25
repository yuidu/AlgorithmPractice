using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestGraph
    {
        public static void Test()
        {
            TestTraverseGraph();
            TestComponentGraph();
        }

        private static void TestTraverseGraph()
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

        private static void TestComponentGraph()
        {
            var graph = new SparseGraph(14, false);
            //Add first component
            graph.AddEdge(7,1);
            graph.AddEdge(7,4);
            graph.AddEdge(7,6);

            graph.AddEdge(6,5);
            graph.AddEdge(5,3);
            graph.AddEdge(5,2);
            graph.AddEdge(3,2);
            graph.AddEdge(2,8);
            graph.AddEdge(8,0);

            //Add second component;
            graph.AddEdge(9,10);
            graph.AddEdge(10,11);
            graph.AddEdge(11,13);
            graph.AddEdge(13,12);


            var componentGraph = new Component(graph);
            Console.WriteLine("this graph contains " + componentGraph.GetComponent() +" separate compoentns");

            var hasPath = componentGraph.HasPath(5,12);
            var msg = (hasPath)?"Yes":"No";
            Console.WriteLine("Does Vertex 5 has a path to vertex 12" + msg);
        }
    }
}