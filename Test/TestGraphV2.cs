using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestGraphV2
    {
        public static void Test()
        {
            //Traverse();
            //CheckHowManyComponents();
            TraverseByBfs();
        }

        public static void Traverse()
        {
            ///  0 ---5-----3
            ///       |-----2
            ///       |-----4----6----7------9------1
            ///                  |----8------|

            SparseGraphV2 graph = new SparseGraphV2(10, false);
            graph.AddEdge(0,5);
            graph.AddEdge(5,3);
            graph.AddEdge(5,2);
            graph.AddEdge(5,4);
            graph.AddEdge(4,6);
            graph.AddEdge(6,7);
            graph.AddEdge(6,8);
            graph.AddEdge(7,9);
            graph.AddEdge(8,9);
            graph.AddEdge(9,1);

            TraverseGraphV2 traverseGraph = new TraverseGraphV2(graph);
            traverseGraph.TraverseGraphFromUsingDfs(graph, 6);
        }


        public static void CheckHowManyComponents()
        {
            ///  0 ---5-----3
            ///       |-----2
            ///       |-----4----6----7------9------1
            ///                  |----8------|
            ///
            ///  10----11----13
            ///  |--12---14--|

            SparseGraphV2 graph = new SparseGraphV2(15, false);
            graph.AddEdge(0,5);
            graph.AddEdge(5,3);
            graph.AddEdge(5,2);
            graph.AddEdge(5,4);
            graph.AddEdge(4,6);
            graph.AddEdge(6,7);
            graph.AddEdge(6,8);
            graph.AddEdge(7,9);
            graph.AddEdge(8,9);
            graph.AddEdge(9,1);

            graph.AddEdge(10,11);
            graph.AddEdge(11,13);
            graph.AddEdge(10,12);
            graph.AddEdge(12,14);
            graph.AddEdge(14,13);

            TraverseGraphV2 traverseGraph = new TraverseGraphV2(graph);            
            Console.WriteLine("Component number is: " + traverseGraph.GetComponentCount());
        }

        public static void TraverseByBfs(){
            ///  0 ---5-----3
            ///       |-----2
            ///       |-----4----6----7------9------1
            ///                  |----8------|

            SparseGraphV2 graph = new SparseGraphV2(10, false);
            graph.AddEdge(0,5);
            graph.AddEdge(5,3);
            graph.AddEdge(5,2);
            graph.AddEdge(5,4);
            graph.AddEdge(4,6);
            graph.AddEdge(6,7);
            graph.AddEdge(6,8);
            graph.AddEdge(7,9);
            graph.AddEdge(8,9);
            graph.AddEdge(9,1);

            TraverseGraphV2 traverseGraph = new TraverseGraphV2(graph);
            traverseGraph.TraverseGraphFromUsingBfs(6);
        }
    }
}