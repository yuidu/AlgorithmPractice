using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestGraphV3
    {
        public static void Test()
        {
            // TestSparseGraph();
            // TestDenseGraph();
            TestGraphPathDfs();
            TestGraphPathBfs();
        }
        public static void TestSparseGraph()
        {
            int n = 10;
            int m = 200;
            var sparse = new SparseGraphV3(n,false);
            
            for(int i=0; i< m; i++)
            {
                var r = new Random();
                var v1 = r.Next() % n;
                var v2 = r.Next() % n;
                sparse.AddEdge(v1,v2);                
            }

            Console.WriteLine("Sparse Graph: ");
            for(int i=0; i<n; i++)
            {
                var vertex = sparse.GetAdjacentVertexes(i);                
                Console.WriteLine(i + " : " + string.Join(',', vertex.ToArray()));
            }           

        }

        public static void TestDenseGraph()        
        {
            int n = 20;
            int m = 100;
            var sparse = new DenseGraphV3(n,false);
            
            for(int i=0; i< m; i++)
            {
                var r = new Random();
                var v1 = r.Next() % n;
                var v2 = r.Next() % n;
                sparse.AddEdge(v1,v2);                
            }

            Console.WriteLine("Dense Graph: ");
            for(int i=0; i<n; i++)
            {
                var edges = sparse.GetAdjacentEdges(i);                
                Console.WriteLine(i + " : " + string.Join(',', edges.ToArray()));
            }           

        }


        /*    |-6
            2-4-7
            |
            | |-8
            3-9-0-1
              |
              5
         */
        public static void TestGraphPathDfs()
        {
            var graph = new SparseGraphV3(10,false);
            graph.AddEdge(4,6);
            graph.AddEdge(4,7);
            graph.AddEdge(2,4);
            graph.AddEdge(2,3);
            graph.AddEdge(3,9);
            graph.AddEdge(9,8);
            graph.AddEdge(9,0);
            graph.AddEdge(9,5);
            graph.AddEdge(0,1);

            for(int i=0; i<10; i++)
            {
                var vertex = graph.GetAdjacentVertexes(i);                
                Console.WriteLine(i + " : " + string.Join(',', vertex.ToArray()));
            }

            var graphPath = new GraphV3Path(graph,6);
            Console.WriteLine("DFS Path is: " + graphPath.FindPath(5));
            Console.WriteLine("DFS Path is: " + graphPath.FindPath(8));
        }

        /*    |-6
            2-4-7
            | |
            | |-8
            3-9-0-1
              |
              5
         */
        public static void TestGraphPathBfs()
        {
            var graph = new SparseGraphV3(10,false);
            graph.AddEdge(4,6);
            graph.AddEdge(4,7);
            graph.AddEdge(2,4);
            graph.AddEdge(4,8);
            graph.AddEdge(2,3);
            graph.AddEdge(3,9);
            graph.AddEdge(9,8);
            graph.AddEdge(9,0);
            graph.AddEdge(9,5);
            graph.AddEdge(0,1);

            for(int i=0; i<10; i++)
            {
                var vertex = graph.GetAdjacentVertexes(i);                
                Console.WriteLine(i + " : " + string.Join(',', vertex.ToArray()));
            }

            var graphPath = new TraverseGraphBFS(graph);
            int step = 0;
            Console.WriteLine("BFS Path is: " + graphPath.FindPath(6,8, out step));            
            Console.WriteLine("Step is: " + step);
        }
    }
}